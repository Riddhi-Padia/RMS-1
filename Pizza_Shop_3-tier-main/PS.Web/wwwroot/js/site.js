// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// login eye js
document.addEventListener("DOMContentLoaded", function() {
    const passwordInput = document.querySelector("#login-pass");
    const eyeHide = document.querySelector("#login-eye-hide");
    const eyeShow = document.querySelector("#login-eye-show");
    
    eyeHide.addEventListener("click", function() {
        passwordInput.setAttribute("type","text");
        eyeHide.classList.add("d-none");
        eyeShow.classList.remove("d-none");
    });

    eyeShow.addEventListener("click", function() {
        passwordInput.setAttribute("type","password");
        eyeShow.classList.add("d-none");
        eyeHide.classList.remove("d-none");
    });
});

// change password page js
document.addEventListener("DOMContentLoaded", function() {
    const passwordInput = document.querySelector("#passchange-1");
    const eyeHide = document.querySelector("#passchange-eye-hide-1");
    const eyeShow = document.querySelector("#passchange-eye-show-1");
    
    eyeHide.addEventListener("click", function() {
        passwordInput.setAttribute("type","text");
        eyeHide.classList.add("d-none");
        eyeShow.classList.remove("d-none");
    });

    eyeShow.addEventListener("click", function() {
        passwordInput.setAttribute("type","password");
        eyeShow.classList.add("d-none");
        eyeHide.classList.remove("d-none");
    });
});

document.addEventListener("DOMContentLoaded", function() {
    const passwordInput = document.querySelector("#passchange-2");
    const eyeHide = document.querySelector("#passchange-eye-hide-2");
    const eyeShow = document.querySelector("#passchange-eye-show-2");
    
    eyeHide.addEventListener("click", function() {
        passwordInput.setAttribute("type","text");
        eyeHide.classList.add("d-none");
        eyeShow.classList.remove("d-none");
    });

    eyeShow.addEventListener("click", function() {
        passwordInput.setAttribute("type","password");
        eyeShow.classList.add("d-none");
        eyeHide.classList.remove("d-none");
    });
});

document.addEventListener("DOMContentLoaded", function() {
    const passwordInput = document.querySelector("#passchange-3");
    const eyeHide = document.querySelector("#passchange-eye-hide-3");
    const eyeShow = document.querySelector("#passchange-eye-show-3");
    
    eyeHide.addEventListener("click", function() {
        passwordInput.setAttribute("type","text");
        eyeHide.classList.add("d-none");
        eyeShow.classList.remove("d-none");
    });

    eyeShow.addEventListener("click", function() {
        passwordInput.setAttribute("type","password");
        eyeShow.classList.add("d-none");
        eyeHide.classList.remove("d-none");
    });
});

// checkbox selection
function togglecheckbox(el){
    const isChecked = el.checked;
    const checkboxes = document.querySelectorAll(".commoncheckbox");

    checkboxes.forEach(checkbox => {
        checkbox.checked = isChecked;
    });
}

// browse file js
function changeFileName(e){
    var fileNameEle = document.getElementById("fileName");
    if(e.target.files[0].name != null){
        fileNameEle.innerHTML = e.target.files[0].name;
    }
    else{
        fileNameEle.innerHTML = "Browse File";
    }
}

// editdelete button hover show in menu page
function showbutton(element) {
    const editbutton = element.querySelector(".editImg");
    const delbutton = element.querySelector(".delImg");

    editbutton.classList.remove("d-none");
    delbutton.classList.remove("d-none");
}

function hidebutton(element) {
    const editbutton = element.querySelector("#editImg");
    const delbutton = element.querySelector("#delImg");

    editbutton.classList.add("d-none");
    delbutton.classList.add("d-none");
}

//search in tables
function SearchTable() {
    // Declare variables
    var input, filter, table, tr, td, i, txtValue;
    input = document.getElementById("myInput");
    filter = input.value.toUpperCase();
    table = document.getElementById("myTable");
    tr = table.getElementsByTagName("tr");
  
    // Loop through all table rows, and hide those who don't match the search query
    for (i = 0; i < tr.length; i++) {
      td = tr[i].getElementsByTagName("td")[0];
      if (td) {
        txtValue = td.textContent || td.innerText;
        if (txtValue.toUpperCase().indexOf(filter) > -1) {
          tr[i].style.display = "";
        } else {
          tr[i].style.display = "none";
        }
      }
    }
  }

//pagination
function paging(){
    
}