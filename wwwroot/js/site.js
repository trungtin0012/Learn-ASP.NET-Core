(function (){
    var sideBarAndWrapper = $("#sidebar,#wrapper");

    $("#toggleSidebar").on("click", function() {
        sideBarAndWrapper.toggleClass("hide-sidebar");

        if(sideBarAndWrapper.hasClass("hide-sidebar")){
            $(this).text("Show Sidebar");
        }
        else{
            $(this).text("Hide Sidebar");
        }
    });
})();