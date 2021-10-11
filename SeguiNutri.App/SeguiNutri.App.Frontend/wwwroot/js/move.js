
$(document).ready(function(){
    var pathname = window.location.pathname;
    console.log(pathname)
    if(pathname == "/Login/Login"){
        document.onmousemove = function(ev){
            var x = -ev.clientX;
            var y = -ev.clientY;
            //background-position
            document.body.style.backgroundPosition = x + 'px' + y + 'px';
        };

    }
  });