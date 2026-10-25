# Part 02 — answers

---

## Reports

- What was the problem?
- I repeat the same code and logic in multiple classess.

- What did you change?
- Create Abstract Classs that contain the shared methods, logic and make all classes implement it and override the different method.

- Why did you choose that approach?
- Because it's an active approach to this case (Template Pattern) that make me set shared data in on class without repeating.

---

## Enrollment

- What was the problem?
- User do the low level details, and heigh cohesion the main class contain alot of classes, and hard to test and edit.

- What did you change?
- used Facade pattern, that I build class that manage all low level details and make user treats one class and this is the user interface.

- Why did you choose that approach?
- this approach solve my problem, that make the user interface clean to treat with only one class and one method that handle all operations
- eliminates the cohesion and easy to test, I treat only one class, if I change any low level details there is no error will occur.
