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