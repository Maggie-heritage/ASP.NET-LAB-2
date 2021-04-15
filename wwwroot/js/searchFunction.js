
    var checkbox = document.getElementById('searchCheckBox');
    var searchTextb = document.getElementById('searchTextBox');
    var searchButton = document.getElementById('searchButton');
checkbox.addEventListener('change', e =>
{


    if (searchButton.disabled == true) {
        searchButton.disabled = false;
        searchTextb.disabled = false;
    }
    else {
        searchButton.disabled = true;
        searchTextb.disabled = true;
    }
});