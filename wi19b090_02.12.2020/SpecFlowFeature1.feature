Feature: SpecFlowFeature1
    In order to avoid silly mistakes
    As a math idiot
    I want to use an easy calculator


Scenario: add two numbers
    Given calculator object
    When adding number 1 and number 2
    Then should return number 3

Scenario: subtract two numbers
    Given calculator object
    When substracting the number 2 from the number1
    Then should return the number 1


Scenario: multiply two numbers
    Given calculator object
    When multypliing the number 1 with the number 2
    Then should return the number 2

Scenario: divide two numbers
    Given calculator object
    When divide the number 2 with the number 1
    Then should return the number 2