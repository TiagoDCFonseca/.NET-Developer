document.querySelector(".accept").addEventListener("click", function(){
    document.querySelector(".cookie-banner").style.display = "none";
    localStorage.setItem("cookiesAccepted", true);
})
document.addEventListener("DOMContentLoaded", function(){
    if(localStorage.getItem("cookiesAccepted")){
        document.querySelector(".cookie-banner").style.display = "none";
    }
})