using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DynaBlazor.Adaptors;
using DynaBlazor.DataGrid;

namespace DynaBlazor.Common
{
    public static class LinqExtension
    {
        public static DataObject ToDynaAdaptor<T>(this IQueryable<T> query,
            DataSettings dataSettings) where T : class
        {
            var appliedToDynaQuery = query;
            if (dataSettings.DataFilter.Any())
            {
                foreach (var i in dataSettings.DataFilter)
                {
                    var prop = typeof(T).GetProperty(i.FilterBy);
                    if (prop == null) continue;
                    appliedToDynaQuery = DataFilterByType(appliedToDynaQuery, prop, i);
                }
            }
            if (dataSettings.ColumnsDirection.Any())
                foreach (var i in dataSettings.ColumnsDirection)
                {
                    if (typeof(T).GetProperties().All(p => p.Name != i.ColumnName))
                        continue;
                    appliedToDynaQuery = appliedToDynaQuery.OrderBy($"{i.ColumnName} {i.OrderDirection}");
                }

            var pageResult =
                appliedToDynaQuery.PageResult(dataSettings.Pagination.CurrentPage, dataSettings.Pagination.PageSize);

            return new DataObject()
            {
                Pagination = {
                    TotalRows = pageResult.RowCount,
                    TotalPages = pageResult.PageCount,
                    CurrentPage= pageResult.CurrentPage,
                },
                Data = pageResult.Queryable,
            };
        }

        private static IQueryable<T> DataFilterByType<T>(IQueryable<T> query, PropertyInfo prop, DataFilter i) where T : class
        {
            switch (prop.PropertyType)
            {
                case Type decimalType when decimalType == typeof(decimal):
                    {
                        var value = Convert.ToDecimal(i.FilterValue);
                        query = query.Where($"{i.FilterBy}.equals(@0)", value);
                        break;
                    }
                case Type intType when intType == typeof(int):
                    {
                        var value = Convert.ToInt32(i.FilterValue);
                        query = query.Where($"{i.FilterBy}.equals(@0)", value);
                        break;
                    }
                case Type doubleType when doubleType == typeof(double):
                    {
                        var value = Convert.ToDouble(i.FilterValue);
                        query = query.Where($"{i.FilterBy}.equals(@0)", value);
                        break;
                    }
                case Type doubleType when doubleType == typeof(double):
                    {
                        var value = Convert.ToDouble(i.FilterValue);
                        query = query.Where($"{i.FilterBy}.equals(@0)", value);
                        break;
                    }
                default:
                    {
                        query = query.Where($"{i.FilterBy}.contains(@0)", i.FilterValue);
                        break;
                    }
            }

            return query;
        }
    }
}
