// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Load table from right
const rows = Array.from(document.querySelectorAll('tr'));

function slideOut(row) {
    row.classList.add('slide-out');
}

function slideIn(row, index) {
    setTimeout(function () {
        row.classList.remove('slide-out');
    }, (index + 5) * 200);
}

rows.forEach(slideOut);

rows.forEach(slideIn);

// Load table from centre
const rows2 = Array.from(document.querySelector('table.tableSlide2').querySelectorAll('tbody tr'));

function slideOut(row) {
  row.classList.add('slide-out');
}

function slideIn(row, index) {
  setTimeout(function () {
    row.classList.remove('slide-out');
  }, (index + 5) * 200);
}

rows2.forEach(slideOut);

rows2.forEach((row, index) => slideIn(row, index));

// Show/ Hide Password:
function myPasswordFunction() {
    var x = document.getElementById("passwordInput");
    if (x.type === "password") {
        x.type = "text";
    } else {
        x.type = "password";
    }
}

// Popup Scout
// Popup
function showPopup(element) {
    const popup = document.getElementById('popup');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup() {
    const popup = document.getElementById('popup');
    popup.style.display = 'none'; // Hide the popup
}

// popup2
function showPopup2(element2) {
    const popup = document.getElementById('popup2');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup2() {
    const popup = document.getElementById('popup2');
    popup.style.display = 'none'; // Hide the popup
}


// popup3
function showPopup3(element3) {
    const popup = document.getElementById('popup3');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup3() {
    const popup = document.getElementById('popup3');
    popup.style.display = 'none'; // Hide the popup
}

// popup4
function showPopup4(element4) {
    const popup = document.getElementById('popup4');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup4() {
    const popup = document.getElementById('popup4');
    popup.style.display = 'none'; // Hide the popup
}

// popup5
function showPopup5(element5) {
    const popup = document.getElementById('popup5');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup5() {
    const popup = document.getElementById('popup5');
    popup.style.display = 'none'; // Hide the popup
}

// popup6
function showPopup6(element6) {
    const popup = document.getElementById('popup6');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup6() {
    const popup = document.getElementById('popup6');
    popup.style.display = 'none'; // Hide the popup
}

// popup7
function showPopup7(element7) {
    const popup = document.getElementById('popup7');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup7() {
    const popup = document.getElementById('popup7');
    popup.style.display = 'none'; // Hide the popup
}

// popup8
function showPopup8(element8) {
    const popup = document.getElementById('popup8');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup8() {
    const popup = document.getElementById('popup8');
    popup.style.display = 'none'; // Hide the popup
}


// popup9
function showPopup9(element9) {
    const popup = document.getElementById('popup9');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup9() {
    const popup = document.getElementById('popup9');
    popup.style.display = 'none'; // Hide the popup
}

// popup10
function showPopup10(element10) {
    const popup = document.getElementById('popup10');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup10() {
    const popup = document.getElementById('popup10');
    popup.style.display = 'none'; // Hide the popup
}

// popup11
function showPopup11(element11) {
    const popup = document.getElementById('popup11');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup11() {
    const popup = document.getElementById('popup11');
    popup.style.display = 'none'; // Hide the popup
}

// popup12
function showPopup12(element12) {
    const popup = document.getElementById('popup12');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup12() {
    const popup = document.getElementById('popup12');
    popup.style.display = 'none'; // Hide the popup
}

// popup13
function showPopup13(element13) {
    const popup = document.getElementById('popup13');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup13() {
    const popup = document.getElementById('popup13');
    popup.style.display = 'none'; // Hide the popup
}


// popup14
function showPopup14(element14) {
    const popup = document.getElementById('popup14');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup14() {
    const popup = document.getElementById('popup14');
    popup.style.display = 'none'; // Hide the popup
}


function showPopup15(element15) {
    const popup = document.getElementById('popup15');
    const tableRect = document.querySelector('.tableSlide').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopup15() {
    const popup = document.getElementById('popup15');
    popup.style.display = 'none'; // Hide the popup
}


// Popup TS
function showPopupts(element) {
    const popup = document.getElementById('popup');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts() {
    const popup = document.getElementById('popup');
    popup.style.display = 'none'; // Hide the popup
}

// popup2
function showPopupts2(element2) {
    const popup = document.getElementById('popup2');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts2() {
    const popup = document.getElementById('popup2');
    popup.style.display = 'none'; // Hide the popup
}


// popup3
function showPopupts3(element3) {
    const popup = document.getElementById('popup3');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts3() {
    const popup = document.getElementById('popup3');
    popup.style.display = 'none'; // Hide the popup
}

// popup4
function showPopupts4(element4) {
    const popup = document.getElementById('popup4');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts4() {
    const popup = document.getElementById('popup4');
    popup.style.display = 'none'; // Hide the popup
}

// popup5
function showPopupts5(element5) {
    const popup = document.getElementById('popup5');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts5() {
    const popup = document.getElementById('popup5');
    popup.style.display = 'none'; // Hide the popup
}

// popup6
function showPopupts6(element6) {
    const popup = document.getElementById('popup6');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts6() {
    const popup = document.getElementById('popup6');
    popup.style.display = 'none'; // Hide the popup
}

// popup7
function showPopupts7(element7) {
    const popup = document.getElementById('popup7');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's phideosition and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts7() {
    const popup = document.getElementById('popup7');
    popup.style.display = 'none'; // Hide the popup
}

// popup8
function showPopupts8(element8) {
    const popup = document.getElementById('popup8');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts8() {
    const popup = document.getElementById('popup8');
    popup.style.display = 'none'; // Hide the popup
}


// popup9
function showPopupts9(element9) {
    const popup = document.getElementById('popup9');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts9() {
    const popup = document.getElementById('popup9');
    popup.style.display = 'none'; // Hide the popup
}

// popup10
function showPopupts10(element10) {
    const popup = document.getElementById('popup10');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts10() {
    const popup = document.getElementById('popup10');
    popup.style.display = 'none'; // Hide the popup
}

// popup11
function showPopupts11(element11) {
    const popup = document.getElementById('popup11');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts11() {
    const popup = document.getElementById('popup11');
    popup.style.display = 'none'; // Hide the popup
}

// popup12
function showPopupts12(element12) {
    const popup = document.getElementById('popup12');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts12() {
    const popup = document.getElementById('popup12');
    popup.style.display = 'none'; // Hide the popup
}

// popup13
function showPopupts13(element13) {
    const popup = document.getElementById('popup13');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts13() {
    const popup = document.getElementById('popup13');
    popup.style.display = 'none'; // Hide the popup
}


// popup14
function showPopupts14(element14) {
    const popup = document.getElementById('popup14');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts14() {
    const popup = document.getElementById('popup14');
    popup.style.display = 'none'; // Hide the popup
}


function showPopupts15(element15) {
    const popup = document.getElementById('popup15');
    const tableRect = document.querySelector('.tableSlide2').getBoundingClientRect(); // Get the table's position and dimensions

    // Calculate popup position to cover the entire table
    const popupTop = tableRect.top;

    popup.style.top = `${popupTop}px`;
    popup.style.display = 'block'; // Show the popup
}

function hidePopupts15() {
    const popup = document.getElementById('popup15');
    popup.style.display = 'none'; // Hide the popup
}
