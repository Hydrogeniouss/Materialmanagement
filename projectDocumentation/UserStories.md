#UserStories

# User

| I, as a | want                                                  | because                                                                                 | Acceptance criterion                                                                                                                                       | rating |
| ------- | ----------------------------------------------------- | --------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| Member  | to be able to borrow one or several materials quickly | I probably won't do it otherways                                                        | - menu for borrowing materials over a drop down menu<br>- a number field for the quantity of each item<br>- possibility to borrow several items at a time  | MVP    |
| Member  | to log in                                             | I dont want to enter my full contact details every time.                                | - possibility to create an account<br>- possibility to log in over Name and PIN (8 chars)                                                                  | MVP    |
| Member  | to give back borrow Materials                         | then someone else can borrow it.                                                        | - view of all borrowed equipment<br>- checkbox for each material <br>- checkbox to mark all materials<br>- button where all checked materials are returned | MVP    |
| Member  | to see wich materials are currently in storage        | I want to know what materials I can use for my next activity                            | - view for all materials that are not borrowed at a time                                                                                                   | MVP    |
| Member  | to see all the materials we have                      | I want to be able to plan for future Projects, regardless of what is borrowed currently | - view for all the materials                                                                                                                               | MVP    |

# Administrator

| I, as a       | want                                                                        | because                                                  | Acceptance criterion                                                                                                                                            | rating |
| ------------- | --------------------------------------------------------------------------- | -------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| Administrator | to create new Materials                                                     | we regularly buy new equipment.                          | - possibility to create a new material (with `Brand`, `Name`, `Type`, `technical information`, `description`)                                                   | MVP    |
| Administrator | a loan history                                                              | I want to understand who lent which equipment.           | - a table that saves all the lent out materials (`person`, `material`, `date of lending`, `date of giving back`)                                                | MVP    |
| Administrator | to see who has lent a material at the current point                         | I want to be able to see who has the equipment currently | - a tab where a list is of currently lent out materials. (maybe a select on the loan history where `date of giving back` = `null`?)                             | MVP    |
| Administrator | to manage existant accounts                                                 | I want to confirm proper usage                           | - a tab with an overview of existing accounts and the ability to manage their borrowed materials and account data                                               | MVP    |
| Administrator | to delete existing materials                                                | sometimes equipment is too old for use or breaks         | - view of all materials<br>- checkbox for each material <br>- checkbox to mark all materials<br>- button to delete items<br>- pop up that asks for confirmation | MVP    |
| Administrator | issue reminders to people reaching their time limit for borrowing equipment | i want to keep order                                     | - a button on the user page to issue warnings reminding the user of the limit when next logging in                                                              | NTH    |


> [!NOTE] glossary:
> 
> Rating:
> - MVP: Minimal Viable Product
> - NTH: Nice to have
> 
>Wording:
> - material: often used as synonym for equipment in this context





