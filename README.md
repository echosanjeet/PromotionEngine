# PromotionEngine

https:lIconfluence.maerskdev.net/display/SCMP/Coding+Tests 1/2
Classification: Internal
5/30/2020
Pages / New SCM Patform Home
Coding Tests
Coding Tests - New SCM Platform - Confluence
Generic Coding Instructions
• Choose any one of the 2 problems below.
• Should be written in either .net (preferably) -or- java
• The implementation should adopt OOPS, clean code practices, SOLID principles, and best practices.
• Should be accompanied by unit tests (unit test is mandatory) & preferably written using TDD approach
• Should commit code to a public git repository (github) under a public handle
• The codebase should be checked in properly in GitHub. Please DON’T zip and upload. Zip attachment will be straight away rejected.
• Avoid high cyclometric complexity.
• Use generic package names; don’t reference Maersk or any other Maersk brand
• Commits should be incremental so that one can look at the commit log and make sense of how the code has progressed along with the test cases. (recommended atleast upto 20 commits to show how the code progresses; larger number of commits isn’t a problem)
• The promotion rules are mutually exclusive, that implies only one promotion (individual SKU or combined) is applicable to a particular SKU. Rest depends on the imagination of the programmer for which scenarios they want to consider, for example (case 1 => 2A = 30 and A=A40%) or (case 2 => either 2A = 30 or A=A40%)
• Dont spend more than 1.5 hours - 2 hours. The important thing is to understand how the code shapes up and not to cover the entire range of spelling
Problem Statement 1: Promotion Engine
We need you to implement a simple promotion engine for a checkout process. Our Cart contains a list of single character SKU ids (A, B, C. .. ) over which the promotion engine will need to run.
The promotion engine will need to calculate the total order value after applying the 2 promotion types
• buy 'n' items of a SKU for a fixed price (3 A's for 130)
• buy SKU 1 & SKU 2 for a fixed price ( C + D = 30 )
The promotion engine should be modular to allow for more promotion types to be added at a later date (e.g. a future promotion could be x% of a SKU unit price). For this coding exercise you can assume that the promotions will be mutually exclusive; in other words if one is applied the other promotions will not apply
Test Setup
Unit price for SKU IDs A 50
B 30
C 20
D 15
Active Promotions
3 of A's for 130
2 of B's for 45 C & D for 30
Scenario A
1
* A
50
1
* B
30
1
* C
20
Total
100
Scenario
B
5 * A
130 + 2*50
5 * B
45 + 45 + 30
1 * C
28
Total 370