

//string text = "Hello Bello";
//for (int i = 0; ++i < 10; ) { //iteracyjnie
//    Console.WriteLine(text+" i = "+i);
//}

void Hello(string text, int ile) {
    Console.WriteLine(text + " ile przed ifem = " + ile);
    if(ile<9) Hello(text,++ile);
    Console.WriteLine(text + " ile po ifie = " + ile);
}
Hello("ala ma kota",0);
