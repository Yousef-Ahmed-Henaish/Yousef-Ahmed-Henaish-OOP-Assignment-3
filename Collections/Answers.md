## Task 2.1 — Research: IReadOnlyDictionary & SortedDictionary
answer in your own words: ; , and;; and
1. what is each one
- IReadOnlyDictionary: Interface that means base dictionary but for read only, cannot edit it by methods like Add, Remove, ...
- SortedDictionary: Collection type like base dictionary but differs in storing way, this type sorted but with operations complixety NLogN because it use binary search tree instad of HashTable.

2. how isIReadOnlyDictionary different from Dictionary
- isIReadOnlyDictionary: Interface, cannot edit it.
- Dictionary: Reference type, can edit it.

3. why would a public method return oneinstead of a Dictionary
- to avoid editing in my data Because Dictionary is a reference type.

4. how is SortedDictionary different from Dictionary in ordering and in lookup speed
- Dictionary: Rendom Sorting, (1) for all opertations.
- SortedDictionary: Sorted Data, NLogN for all operations.

5. when would you choose it?
- SortedDictionary: if my logic need sorted data.
- IReadOnlyDictionary: if I need to share the dictionary data and avoid editing it.

## Task 2.2 — Pick the Collection

List, , HashSet, IEnumerable, IReadOnlyDictionary, SortedDictionary.

1. Dictionary          =>  Find a student by national ID — thousands of times a day.
2. HashSet             =>  Keep the tags of a course. The same tag must never be stored twice.
3. List                =>  Keep a student's grades in the order they were entered. The same grade can appear more than once.
4. IReadOnlyDictionary =>  public method returns the course price list. Callers can read prices but must not add or change any.
5. SortedDictionary    =>  A timetable keyed by session start time. Sessions are added at any moment, and it must always print in time order.
6. IEnumerable         =>  A method returns results that the caller only loops over once — and may stop early.