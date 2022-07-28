using ReferenceAndValeuTypes;

//Verschil tussen reference type en value type. Reference type kan de effectieve plaats in het geheugen van waarde wijzigen. Speel rond met de Values om het verschil duidelijk te maken.

Valuetypes();
ReferenceTypes();

void Valuetypes() {
    int firstNumber = 5;
    int secondNumber = 7;
    PrintValues(firstNumber, secondNumber);  // ongewijzigde waardes

    secondNumber = firstNumber;
    PrintValues(firstNumber, secondNumber); // gekopieerde waarde

    secondNumber = 12;
    PrintValues(firstNumber, secondNumber); // gewijzigde waarde
}

void PrintValues (int a, int b) {
    Console.WriteLine($"First Value: {a}\nSecond value: {b}\n");
}


void ReferenceTypes() {
    Student student = new Student("Bram", 15, "België");
    Student student2 = new Student("Jessica", 20, "Zambia");

    Console.WriteLine(student.ToString());
    Console.WriteLine(student2.ToString());
    Console.WriteLine();

    student2 = student; // Overschreven waarde DONT DO THIS tenzij ge weet waarom
    Console.WriteLine(student.ToString());
    Console.WriteLine(student2.ToString());
    Console.WriteLine();

    student2.Naam = "Berta"; // gewijzigde waarde + beide objecten refereren naar dezelfde plaats in het heap(geheugen) maar er bestaan nog twee plaatsen in de heap

    Console.WriteLine(student.ToString());
    Console.WriteLine(student2.ToString());
    Console.WriteLine();
}
