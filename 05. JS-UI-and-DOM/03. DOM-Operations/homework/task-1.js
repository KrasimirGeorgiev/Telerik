'strict';
function solve() {
  return function(element, contents) {
    var item,
        length = contents.length,
        newDiv = document.createElement(div),
        div,
        docFragment = document.createDocumentFragment(),
        i;

    if (typeof element !== 'string' && element.nodeType !== 1) {
      throw new Error();
    }

    if (typeof element === 'string') {
      item = document.getElementById(element);
      if (!item) {
        throw new Error();
      }
    } else {
      item = element;
    }

    for (i = 0; i < length; i++) {
      if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
        throw new Error();
      }
    }

    item.innerHTML = '';
    for (i = 0; i < length; i++) {
      div = newDiv.cloneNode(true);
      div.innerHTML = contents[i];
      docFragment.appendChild(div);
    }

    item.appendChild(docFragment);
  };
}

module.exports = solve;
