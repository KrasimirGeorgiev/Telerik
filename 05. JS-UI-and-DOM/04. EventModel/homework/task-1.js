'strict';
function solve() {
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

    element.addEventListener('click', function hideOrShowElements(ev) {
        var targetEl = ev.target,
            nextEl = targetEl.nextElementSibling,
            contentEl;

        if (nextEl === null || nextEl.className === 'button') {
            return;
        }

        while (nextEl) {
            if (nextEl.className === 'content') {
                contentEl = nextEl;
                break;

            } else {
                nextEl = nextEl.nextElementSibling;
            }
        }

        if (contentEl.style.display === '') {
            targetEl.innerHTML = 'show';
            contentEl.style.display = 'none';
        } else {
            targetEl.innerHTML = 'hide';
            contentEl.style.display = '';
        }
    }, false);
  };
}
