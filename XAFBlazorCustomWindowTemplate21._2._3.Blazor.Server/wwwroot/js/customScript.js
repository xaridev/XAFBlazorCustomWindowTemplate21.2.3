
globalThis.customScript = {
    showDetailViewController: null,
    registerController: function (controller, objectId) {
        globalThis.customScript.showDetailViewController = controller;
        globalThis.customScript.showDetailViewController.invokeMethodAsync("ShowDetailView", objectId);
    },
}
