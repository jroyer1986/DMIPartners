public void DoSomething(int CustomerID) {
  try {
    var x = GetPersonByID(CustomerID);
    if (x.Name.Length() > 25) {
      x.Name = x.Name.Substring(0, 25);
    }
    DoSomethingElse(x);
  } catch (Exception ex) {
  throw new Exception("Customer not found!");
  }
  Console.WriteLine("done doing something!");
}    