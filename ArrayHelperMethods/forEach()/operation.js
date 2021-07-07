const works = ["Write an article", "Write code", "Complete the project "]; //array variables

var toDo = document.querySelector('#todo');

works.forEach(function (work, index) {

    CreateWork(work);

});



toDo.addEventListener('click', function (work) {

    if (work.target.tagName = 'li') {
        work.target.classList.toggle('check');
    }
});


document.querySelector('#add_btn').onclick = function () {

    var work = document.querySelector('#add').value;
    if (work == '') {
        alert("Please don't blank");
        return;
    }
    CreateWork(work);

};


function CreateWork(work) {
    var li = document.createElement('li'); // li adında bir nesne oluşturduk ve nesnemizin etiketini de createElement ile li adında belirledik
    var txt = document.createTextNode(work);

    li.className = 'alert alert-info';
    li.appendChild(txt); // li parent txt - works ise child konumundadır.

    toDo.appendChild(li);

    var span = document.createElement('span');
    var text = document.createTextNode('\u00D7');

    span.className = ' close btn ';
    span.appendChild(text);
    li.appendChild(span);

    span.onclick = function () {
        var li = this.parentElement;
        li.style.display = 'none';
    }
}


