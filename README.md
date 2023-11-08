# Election Day

## Preparation

* Fork this Repository
* Clone YOUR fork
* Compete as many iterations as time allows
* Commit your work and Push your solution to your fork (We will do this step as a group :) )
* Send a link to your fork to your instructors (this is not graded, but we want to see how far folks got)

## Iteration 1

Create a `Candidate` class that responds to the following interaction pattern. There are also tests you should run to check that your code works as expected!

```c#
var diana = new Candidate("Diana D", "Democrat");

Console.WriteLine(diana.Name);
// Output => "Diana D"

Console.WriteLine(diana.Party);
// Output => "Democrat"

Console.WriteLine(diana.Votes);
// Output => 0

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);
// Output => 3
```

## Iteration 2

Create a `Race` class that responds to the following interaction pattern.

The `RegisterCandidate` method must take a Candidate object as an argument and doesn't return anything.

```c#
var race = new Race("City Council District 10");

race.Office
// Output => "City Council District 10"

foreach (var candidate in race.Candidates)
{
  Console.WriteLine(candidate.Name);
}
// Output => ""

var diana = new Candidate("Diana D", "Democrat");
race.RegisterCandidate(diana);

foreach (var candidate in race.Candidates)
{
  Console.WriteLine(candidate.Name);
}
// Output => "Diana D"
```

## 🌶️ Iteration 3

Create an `Election` class that satisfies the following requirements.

You have been contacted by the local government to create a program that helps track their elections by organizing registered candidates and their votes.

| Method Name | Return Value |
| ----------- | ------------ |
| new (the constructor)         | An `Election` object that has an attribute of year (string data type). |
| Year        | The year of the election (string). |
| Races       | An list of `Race` objects. |
| AddRace(race)   | Add input to list of `Race` objects. |
| AllCandidates()  | An list of all `Candidate` objects in the election. |
| VoteCounts() | A dictionary with each candidate's name as a key and their count of votes as the value. |


## 🌶️🌶️ Iteration 4

Add the following methods on the `Race` class. You may need to add additional property(s) to implement this functionality.

The local government agency has contacted you about compiling addition information about each of the races.

| Method Name            | Return Value |
| ---------------------- | ------------ |
| IsOpen                 | A boolean indicating whether the race is open or not. A race should be open by default. |
| Close()                | Close the race (should no longer be open). |
| 🌶️ Winner()      | `false` if the race is still open. It should return the candidate with the most votes if not open. If there is a tie, it should return any candidate with the highest number of votes. |
| 🌶️ IsTie         | A boolean indicating if two or more candidates share the highest number of votes. |
