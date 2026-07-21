# Understanding Inheritance in Object-Oriented Programming

**By Carlos Roberto Silva**

At its heart, inheritance is all about not reinventing the wheel. It’s one of the most fundamental concepts in object-oriented programming because it lets us build new classes directly on top of work we’ve already done. Instead of copying and pasting the same code over and over, a derived class can pull in the shared attributes and behaviors from a base class, leaving us to write only the code that makes the new class different. For my assignment, I built a base `Assignment` class to store the information that every single assignment shares, like the student's name and the topic.

From there, creating the `MathAssignment` and `WritingAssignment` classes was incredibly straightforward. Both subclasses automatically inherited those core fields while introducing their own unique details. The math class tracked specific sections and problem numbers, whereas the writing class stored the paper's title. This structure kept the entire program organized and cut out any unnecessary repetition.

One of the best things about using inheritance is how easy it makes managing a codebase as it grows. Because the shared functionality is centralized in a single base class, fixing a bug or making an improvement only has to happen once. The moment you update the base class, every derived class gets those benefits automatically. It also creates a design that mirrors real-world relationships, which makes the code a lot more intuitive to read and reason about.

In this project, since a math homework sheet and a writing essay are obviously both specific types of assignments, organizing them through inheritance just felt like the most natural solution. It kept the logic clean, minimized clutter, and made the whole system a lot easier to scale down the road.
