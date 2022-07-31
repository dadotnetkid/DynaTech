function ShowModal(modalId) {
    let modalEl = document.getElementById(modalId);
    let modal = bootstrap.Modal.getOrCreateInstance(modalEl);
    modal.show();
}
function HideModal(modalId) {
    let modalEl = document.getElementById(modalId);
    let modal = bootstrap.Modal.getOrCreateInstance(modalEl);
    modal.hide()
}
function ShowToast(elementId) {
    let myToastEl = document.getElementById(elementId);
    let myToast = bootstrap.Toast.getOrCreateInstance(myToastEl);
    myToast.show();

} function ShowToastByClass() {
    let myToastEl = document.querySelector('.toast');
    let myToast = bootstrap.Toast.getOrCreateInstance(myToastEl);
    myToast.show();
}
function FocusOnElement(elementId) {
    document.getElementById(elementId).focus();
}
function Debug(message) {
    console.log(message);
}