#UserStories

# User

| NR*XXX* | I, as a | want                                                  | because                                                                                 | Acceptance criteria                                                                                                                                       | rating |
| ------- | ------- | ----------------------------------------------------- | --------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| NR001   | Member  | to be able to borrow one or several materials quickly | I probably won't do it otherwise                                                        | - menu for borrowing materials over a drop down menu<br>- a number field for the quantity of each item<br>- possibility to borrow several items at a time  | MVP    |
| NR002   | Member  | to return borrowed Materials                          | then someone else can borrow it.                                                        | - view of all borrowed equipment<br>- checkbox for each material <br>- checkbox to mark all materials<br>- button which returns all marked pieces of equipment | MVP    |
| NR003   | Member  | to log in                                             | I dont want to enter my full contact details every time.                                | - possibility to create an account<br>- possibility to log in over Name and PIN (8 chars)                                                                  | MVP    |
| NR004   | Member  | to see which materials are currently in storage       | I want to know what materials I can use for my next activity                            | - view for all materials that are not borrowed at a time                                                                                                   | NTH    |
| NR005   | Member  | to see all the materials we have                      | I want to be able to plan for future Projects, regardless of what is borrowed currently | - view for all the materials                                                                                                                               | NTH    |
| NR006   | Member  | to see which materials I currently have borrowed      | I want to know when I have to give back which materials                                 | - view for all the currently borrowed materials of a member                                                                                                | MVP    |


# Administrator

| NR*XXX* | I, as a       | want                                                                            | because                                                  | Acceptance criterion                                                                                                                                            | rating |
| ------- | ------------- | ------------------------------------------------------------------------------- | -------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------ |
| NR101   | Administrator | to create new Materials                                                         | we regularly buy new equipment.                          | - possibility to create a new material (with `Brand`, `Name`, `Type`, `technical information`, `description`)                                                   | MVP    |
| NR102   | Administrator | a loan history                                                                  | I want to understand who lent which equipment.           | - a table that saves all the lent out materials (`person`, `material`, `date of lending`, `date of giving back`)                                                | MVP    |
| NR103   | Administrator | to see who has lent a material at the current point                             | I want to be able to see who has the equipment currently | - a tab where a list is of currently lent out materials. (maybe a select on the loan history where `date of giving back` = `null`?)                             | MVP    |
| NR104   | Administrator | to manage existant accounts                                                     | I want to confirm proper usage                           | - a tab with an overview of existing accounts and the ability to manage their borrowed materials and account data                                               | MVP    |
| NR105   | Administrator | to delete existing materials                                                    | sometimes equipment is too old for use or breaks         | - view of all materials<br>- checkbox for each material <br>- checkbox to mark all materials<br>- button to delete items<br>- pop up that asks for confirmation | MVP    |
| NR106   | Administrator | issue reminders to people reaching their time limit for borrowing equipment     | I want to keep order                                     | - a button on the user page to issue warnings reminding the user of the limit when next logging in                                                              | NTH    |






> [!NOTE] glossary:
> 
> Rating:
> - MVP: Minimal Viable Product
> - NTH: Nice to have
> 
>Wording:
> - material: often used as synonym for equipment in this context





