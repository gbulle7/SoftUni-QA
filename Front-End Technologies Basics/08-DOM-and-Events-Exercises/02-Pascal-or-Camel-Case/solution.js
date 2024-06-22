function solve() {
  let textInput = document.getElementById("text").value.toLowerCase();
  let namingConvention = document.getElementById("naming-convention").value;
  let resultField = document.getElementById("result");

  let resultText = '';
  let splitText = textInput.split(" ");
  
  if (namingConvention == "Camel Case") {
    resultText += splitText[0]
    for (let i = 1; i < splitText.length; i++) {
      resultText += splitText[i][0].toUpperCase() + splitText[i].slice(1, splitText[i].length);
    }
    resultField.textContent = resultText;
  }
  else if (namingConvention == "Pascal Case") {
    for (let i = 0; i < splitText.length; i++) {
      resultText += splitText[i][0].toUpperCase() + splitText[i].slice(1, splitText[i].length);
    }
    resultField.textContent = resultText;
  }
  else {
    resultField.textContent = 'Error!'
  }
  
}
