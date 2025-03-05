#UserStories

# User

| I, as a | want                                                  | because                                                  | Acceptance criterion                                                                                                                                                        | rating |
| ------- | ----------------------------------------------------- | -------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| Member  | to be able to borrow one or several materials quickly | I probably won't do it otherways                         | - menu for borrowing materials over a drop down menu<br>- a number field for the quantity of each item<br>- possibility to borrow several items at a time                   | MVP    |
| Member  | to log in                                             | I dont want to enter my full contact details every time. | - possibility to create an account<br>- possibility to log in over Name and PIN (8 chars)                                                                                   | MVP    |
| Member  | to give back borrow Materials                         | then someone else can borrow it.                         | - tab where all your borrowed equipment is listed<br>- checkbox for each material <br>- checkbox to mark all materials<br>- button where all checked materials are returned | MVP    |
| Member  |                                                       |                                                          |                                                                                                                                                                             |        |


# Administrator

| I, as a       | want                                                | because                                                  | Acceptance criterion                                                                                                                | rating |
| ------------- | --------------------------------------------------- | -------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- | ------ |
| Administrator | to create new Materials                             | we regularly buy new equipment.                          | - possibility to create a new material (with `Brand`, `Name`, `Type`, `technical information`, `description`)                       | MVP    |
| Administrator | a loan history                                      | I want to understand who lent which equipment.           | - a table that saves all the lent out materials (`person`, `material`, `date of lending`, `date of giving back`)                    | MVP    |
| Administrator | to see who has lent a material at the current point | I want to be able to see who has the equipment currently | - a tab where a list is of currently lent out materials. (maybe a select on the loan history where `date of giving back` = `null`?) | MVP    |
| Administrator | to manage existant accounts                         | I want to confirm proper usage                           | - a tab with an overview of existing accounts and the ability to manage their borrowed materials and account data                   | MVP    |
| Administrator | issue reminders to people reaching their limit      | i want to keep order                                     | - a button on the user page to issue warnings reminding the user of the limit when next logging in                                  | NTH    |
