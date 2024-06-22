function toggle() {
    let textDiv = document.getElementById("extra");
    let button = document.getElementsByClassName("button")[0];

    if (button.textContent == "More") {
        textDiv.style.display = "block";
        button.textContent = "Less";
    }
    else {
        textDiv.style.display = "none";
        button.textContent = "More";
    }
}


// function toggle() {
//     let button = document.querySelector('.button');
//     let text = document.getElementById('extra');

//     button.textContent = button.textContent == 'More' ? 'Less' : 'More';
//     text.style.display =
//         text.style.display == 'none' || text.style.display == '' ?
//         text.style.display = 'block' : text.style.display = 'none';
// }