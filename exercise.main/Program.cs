using exercise.main;

var _customerBasket = new CustomerBasket();

_customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
_customerBasket.AddItem("COFB" , 0.99f , "Coffee" , "Black");
_customerBasket.AddSpecialOffer("COFB" , 1.25f);

var receipt = new Receipt(_customerBasket);
receipt.PrintReceipt();
