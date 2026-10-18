# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?
- If I need to add new shipping company I must open the class and edit it (Violate OCP).

- What did you change?
- Build an interface that contain the method, and make my class take object of class that implement this interface and return the result of the method that in the objct.
- Now If I need to add new shipping company, I will create new class and implement the interface only.

---

## OrderProcessor

- What was the problem?
- It was conatain Sql Storage method and Email Sender (Violate Single Resposibility)

- What did you change?
- Create an two interfaces, one for storage and one for SmtpSending and make my class take parameters objects from classes that implement this interface
- Now the main class just manage the operation not more, and I can add any other ways or change the work way.

---

## Notifications

- What was the problem?
- Depth of inheritance: there is 3 levels of inheritance that make the system more complecataed, and if I need to add other way will make the system complix more.

- What did you change?
- Create a record that contain all properties that I need to the notification and relied on composition rather than inheritance.
- Create an interface, now any notification type should implement this interface.
- make my class take parametrs INotificationChannel interface, and object of the Request record, now my class just manage not more.
---

## Proof

- New carrier file(s):
- New notification channel file(s):

- Existing classes left unchanged? (yes/no):
- yes, the logic changing largely. 
