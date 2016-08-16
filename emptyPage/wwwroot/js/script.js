function startup() {
        
    
    var element = $("#testID");
    element.text("Shane Drafahl");
    var main = $("#main");
    
    main.on("mouseenter", function (){
        main.css("background-color", "yellow");
    });
    
    main.on("mouseleave", function (){
        main.css("background-color", "white");
    });

    var menuIte = $("ul.menu li a");
    menuIte.on("click", function(){
        alert("hello");
    });
}

//startup();

var $topArea =$("#sidebard,#wrapper");
$("#sideBarToggle").on("click",function(){
    $topArea.toggleClass("hSidebar");
    if($topArea.hasClass("hSidebar")){
        $(this).text("show");
    }else{
        $(this).text("hide");
    }
})


