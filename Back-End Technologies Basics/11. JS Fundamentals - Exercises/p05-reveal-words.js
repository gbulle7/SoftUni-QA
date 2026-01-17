function solve(words, text) {
    let wordsArray = words.split(', ');

    for (let word of wordsArray) {;
        text = text.replace('*'.repeat(word.length), word);
    }
    
    console.log(text);
}