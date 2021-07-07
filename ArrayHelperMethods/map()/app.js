let users = [
    {firstName : "Necla", lastName: "Canveren"},
    {firstName : "Asel", lastName: "Güzel"},
    {firstName : "Yusuf", lastName: "Babacan"}
  ];

  
  // Get the modal
var modal = document.getElementById("myModal");

// Get the button that opens the modal
var btn = document.getElementById("add_btn");

// Get the <span> element that closes the modal
var span = document.getElementsByClassName("close")[0];

// When the user clicks the button, open the modal 
btn.onclick = function() {
  modal.style.display = "block";

}

// When the user clicks on <span> (x), close the modal
span.onclick = function() {
  modal.style.display = "none";
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function(event) {
  if (event.target == modal) {
    modal.style.display = "none";    
  }
  let userFullnames = users.map(function(element){
    return '<li>' + `${element.firstName} ${element.lastName}`+ '</li>';
})

document.getElementById('list').innerHTML = userFullnames.join(" ");
}