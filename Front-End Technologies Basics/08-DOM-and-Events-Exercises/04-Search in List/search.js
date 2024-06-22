function search() {
   let searchValue = document.getElementById("searchText").value;
   let liElements = document.querySelectorAll("li");
   let resultDiv = document.getElementById("result");

   let matches = 0;
   // if (!searchValue) {searchValue = "\u0000"}
   if (!searchValue) {
      resultDiv.textContent = `0 matches found`;
      return;
   }

   // listItems.forEach(item => {
   //    if (item.textContent.toLowerCase().includes(searchValue.toLowerCase())) {
   //       item.style.fontWeight = 'bold';
   //       item.style.textDecoration = "underline";
   //       matches++;
   //    }
   // });

   for (let i = 0; i < liElements.length; i++) {
      if (liElements[i].textContent.toLowerCase().includes(searchValue.toLowerCase())) {
         liElements[i].style.fontWeight = 'bold';
         liElements[i].style.textDecoration = "underline"
         matches++;
      }
      else {
         liElements[i].style.fontWeight = '';
         liElements[i].style.textDecoration = '';
         
      }
   }

   resultDiv.textContent = `${matches} matches found`
}
