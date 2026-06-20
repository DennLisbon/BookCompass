const bookResult = {
    name: "The Book Thief",
    pages: 250,
    messageResult: function() {
        return "Here is your book: " + this.name + ". It has " + this.pages + " for your to explore!";
    }
};

console.log(bookResult.messageResult()); // "Hello, my name is Bob"