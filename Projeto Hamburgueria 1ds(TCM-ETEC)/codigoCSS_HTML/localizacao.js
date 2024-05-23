let slideIndex = 0;

function showSlides(n) {
    const slides = document.getElementsByClassName("imgLocal");
    
    if (n >= slides.length) {
        slideIndex = 0;
    }
    
    if (n < 0) {
        slideIndex = slides.length - 1;
    }
    
    for (let i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    
    slides[slideIndex].style.display = "block";
}

function nextSlide() {
    showSlides(slideIndex += 1);
}

function prevSlide() {
    showSlides(slideIndex -= 1);
}

document.addEventListener("DOMContentLoaded", function () {
    showSlides(slideIndex);
});
