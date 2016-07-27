/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
  return function(item) {
    var element,
        buttonElements,
        contentElements,
        i,
        len,
        clickedElement,
        nextElement;

    if (typeof item !== 'string' && typeof item.nodeType !== 1) { // item instanceof HTMLElement
      throw new Error("Item must be id or DOM element");
    }

    if (typeof item === 'string') {
      element = document.getElementById(item);
      if (!element) {
        throw new Error("Provided ID must belong to an existing DOM element");
      }
    } else {
      element = item;
    }

    buttonElements = element.getElementsByClassName('button');
    contentElements = element.getElementsByClassName('content');
    for (i = 0, len = buttonElements.length; i < len; i++) {
      buttonElements[i].innerHTML = 'hide';
    }

    element.addEventListener('click', function(ev) {
      if (ev.target.className === 'button') {
         clickedElement = ev.target;
         nextElement = clickedElement.nextElementSibling;
         if (!nextElement || nextElement.className === 'button') {
           return;
         }
         while (nextElement) {
           if (nextElement.className === 'content' && nextElement.nextElementSibling.className === 'button') {
             if (nextElement.style.display === 'none') {
               nextElement.style.display = '';
               clickedElement.innerHTML = 'hide';
             } else {
               nextElement.style.display = '';
               clickedElement.innerHTML = 'show';
             }

             break;
           }

           nextElement = nextElement.nextElementSibling;
         }
      }
    }, false);

  };
}
};

module.exports = solve;