# JurassicPark2

P:roblem
Create Dinosaur class
should contain:

- name
- Diet type - Jonathon/Tricia
- WhenAcquired
- Weight
- EnclosureNumber
  Create a method to print out the properties of the dinosaur

List<Dinosaur>
Users can choose from a menu
VIEW
ADD
REMOVE
TRANSFER
SUMMARY
QUIT

E:xamples
Triceratops

- h
- 26000
  Chickens
- C
- 6lbs
  Tyrannosaurus Rex
- c
- 15000
  Stegosaurus
- h
- 11000
  Brontosaurus
- h
- 49000
  Velociraptor
- c
- 100
  Ankylosaurus
- H
- 18000
  Pachycephalosaurus
- H
- 2200
  Therizinosaurus
- H
- 7000
  Compsognathus
- C
- 6
  Diplodocus
- H
- 35000
  Spinosaurus
- C
- 30000

D:ata
class Dinosaur
string Name { get; set; }
string Diet { get; set; }
datetime WhenAcquired { get; set; }
int Weight { get; set; }
int EnclosureNumber { get; set; }

methods
VIEW
ADD
REMOVE
TRANSFER
SUMMARY
QUIT

List<Dinosaur>

A:gorithm

First create dinosaur class

- Create a list
- create instances of the dinosaurs within the list

Create method to describe class
$"{Name} is a {Diet} that was acquired {WhenAcquired}, it weighs {Weight} & is in enclosure {EnclosureNumber}."

Create MENU
to (V)iew
create a for loop to show dinosaur based on Name &/or EnclosureNumber.
"if" no Dinosaurs - "There are no Dinosaurs in the Park."

to (A)dd
Prompt User for:
¿ wh is the name of the species ?
answer - name
¿ wh does it eat ?
answer - Diet type - Jonathon/Tricia

- WhenAcquired - dateTime stamp
  ¿ hw much does it weigh ?
  answer - Weight
  ¿ wh is the enclosure number ?
  answer - EnclosureNumber

to (R)emove
Prompt user for:
¿ wh Name of Dinosaur they want to remove ?

- answer
  Dinosaur present
  ¿ Are you sure ?
  Y - delete dino
  print summary of Dinos we have left
  N - go back to menu

not present
"We don't have that dinosaur, try again"

to (T)ransfer
Prompt user for:
¿ wh dino do you want to move ?
Dinosaur present
¿ wh EnclosureNumber do you want move {Name} to ?
not present
"We don't have that dinosaur, try again"

to (S)ummarize
var carnivoreTotal = 0;
var herbivoreTotal = 0;

if (Dinosaur.Diet = carnivoreTotal)
{
carnivoreTotal += 1;
}
else
{
herbivoreTotal += 1;
}
Console.WriteLine("There are {carnivoreTotal} carnivores. ");
Console.WriteLine("There are {herbivoreTotal} herbivores. ");

to (Q)uit
go back to the menu to repeat or choose another option.
