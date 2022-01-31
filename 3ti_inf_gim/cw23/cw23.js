$(function () {
  $('html').click(function () {
      console.log('ggg');
    const myColor = new Colors();
    console.log(myColor.randomValue());
    console.log(myColor.randomColor());
    $('body').css({
      'background-color': myColor.randomColor(),
      color: myColor.randomColor(),
    });
  });
});

class Colors {
  constructor() {
    this.red = 0;
    this.green = 0;
    this.blue = 0;
  }
  randomColor() {
    return `rgb(${this.randomValue()},${this.randomValue()},${this.randomValue()})`;
  }
  randomValue() {
    return Math.floor(Math.random() * 255);
  }
}
