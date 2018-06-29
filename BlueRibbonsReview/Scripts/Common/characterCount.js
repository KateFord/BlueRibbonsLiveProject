/* Return the number of characters entered into an element identified by it's id */
function getCharacterCount(elementId) {
    return $(elementId).val().length;
}

/*  Set the text attribute of an element, identified by it's id, to the character count with 
*   "character" or "characters" appended. An empty string is returned for a zero count */
function setElementTextAttributeWithCharacterCount(event) {
    var elementId = event.data.elementId;
    var count = getCharacterCount($(this));
    if (count == 1) $(elementId).text(count + " character");
    else if (count > 1) $(elementId).text(count + " characters");
    else $(elementId).text("");
}


