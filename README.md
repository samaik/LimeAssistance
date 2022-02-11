# LimeAssistance

Need help splitting the bill after a lime? LimeAssistance to the rescue! Enter each transaction made by each person and LimeAssistance will calculate the least amount of payments to settle the bill, assuming it will be split evenly.

This is a simple Blazor application I made to help learn the framework. It's going to look sucky at the beginning, but should improve as my skills do.


## Algorithm Used

1. When user enters row, parse input and add amount to new or existing Person object (if valid).
2. Calculate total amount from all Person objects
3. Calculate the amount to be paid by each Person (total / no. of Persons)
4. For each Person, calculate the difference between their total and shared amount and store.
5. For each Person, if difference is -ve, add to a Person with a +ve diff and update the diffs accordingly. Create a Transaction object between these 2 persons to represent the transaction.
6. Continue until each person's diff is 0.

## Objects / Models / Whatevs

**Person**
- name
- total
- diff

**Payment**
- person
- description
- amount

**Transaction**
- personPayer
- personReceiver
- amount
