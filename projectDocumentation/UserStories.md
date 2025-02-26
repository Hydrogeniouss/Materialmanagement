#UserStories

# User

| I, as a | want                                                | because | Acceptance criterion | rating |
| ------- | --------------------------------------------------- | ------- | -------------------- | ------ |
| member  | to be able to lend one or several materials quickly |         |                      | MVP    |


# Administrator

| I, as a       | want                                                | because                                                  | Acceptance criterion                                                                                                                | rating |
| ------------- | --------------------------------------------------- | -------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- | ------ |
| Administrator | to crate new Materials                              | we regularly buy now equipment.                          | - possibility to create a new material (with `Brand`, `Name`, `Type`, `technical information`, `description`)                       | MVP    |
| Administrator | a loan history                                      | I want to understand who lent which equipment.           | - a table that saves all the lent out materials (`person`, `material`, `date of lending`, `date of giving back`)                    | MVP    |
| Administrator | to see who has lent a material at the current point | I want to be able to see who has the equipment currently | - a tab where a list is of currently lent out materials. (maybe a select on the loan history where `date of giving back` = `null`?) | MVP    |
