
globalThis.customScript = {
    showDetailViewController: null,
    registerController: function (controller, objectId) {
        globalThis.customScript.showDetailViewController = controller;
        globalThis.customScript.showDetailViewController.invokeMethodAsync("ShowDetailView", objectId);
    },
}

function OpenMenu() {
    var menu = document.querySelector('#walkme-menu');
    var button = document.querySelector('#walkme-player');

    if (button != null) {
        
        button.style.opacity = 0;
       // button.style.transition = 'display 40000ms ease 0ms !important;';
        
        menu.style.opacity = 1;
       // menu.style.transition = 'display 40000ms ease 0ms !important;';
    }
        
}
function CloseMenu() {
    var menu = document.querySelector('#walkme-menu');
    var button = document.querySelector('#walkme-player');

    if (menu != null) {
        menu.style.opacity = 0;
        //button.classList.add("is-show");
        button.style.opacity = 1;
       
    }

}