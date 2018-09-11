CustomList "-" Operator Documentation:


Definition of Use: 
The "-" operator, when used with two instances of the CustomList class, is used to create a new list with the contents of the first list and the second list combined, without including any duplicated values that may be present in both lists.


Syntax:
(first instance of ListFunctions<T> class) - (second instance of ListFunctions<T> class)


Parameters:
This overload takes exactly two instances of the ListFunctions<T> class as parameters.


Returns:
This overload returns a new instance of the ListFunctions<T> class.


Example:
ListFunctions<int> list1 = new ListFunctions<int>();
ListFunctions<int> list2 = new ListFunctions<int>();

list1.AddList(1);
list1.AddList(2);
list1.AddList(3);
list2.AddList(4);
list2.AddList(2);
list2.AddList(3);
list2.AddList(6);

var listAfterSubtraction = list1 - list2;

//listAfterSubtraction = {1,2,3,4,6}


