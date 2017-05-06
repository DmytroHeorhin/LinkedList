# LinkedList

Test cases:

1.
Given: new LinkedList
When: called Add(string item) method
Then: lenght should be increased from 0 to 1, item should be stored under index 0, added item should be returned

2.
Given: LinkedList with 2 items
When: called Remove() method
Then: lenght should be decreased from 2 to 1, true should be returned

3.
Given: LinkedList with 2 items
When: called ElementAt(int index) method with index 2
Then: IndexOutOfRangeexception should be thrown

4. 
Given: LinkedList with 2 items
When: called ElementAt(int index) method with index -1
Then: IndexOutOfRangeexception should be thrown

5.
Given: LinkedList with 3 items
When: called ElementAt(int index) method with index 2
Then: item from position with index 2 should be returned

6.
Given: LinkedList with 2 items
When: called AddAt(int index) method with index 2
Then: IndexOutOfRangeexception should be thrown

7. 
Given: LinkedList with 2 items
When: called AddAt(int index) method with index -1
Then: IndexOutOfRangeexception should be thrown

8.
Given: LinkedList with 4 items
When: called AddAt(int index) method with index 2
Then: lenght should be increased from 4 to 5, item should be stored under index 2, added item should be returned

9.
Given: LinkedList with 2 items
When: called RemoveAt(int index) method with index 2
Then: IndexOutOfRangeexception should be thrown

10. 
Given: LinkedList with 2 items
When: called RemoveAt(int index) method with index -1
Then: IndexOutOfRangeexception should be thrown

11.
Given: LinkedList with 5 items
When: called RemoveAt(int index) method with index 2
Then: lenght should be decreased from 5 to 4, true should be returned

12.
Given: LinkedList with 4 items
When: LinkedList is used in foreach loop to fill ICollection with its items
Then: ICollection should contain all the items from LinkedList in original order

