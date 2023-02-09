# BankApi #

BankApi enables to create/open new account for existing customer, and get all customer infromation about his accounts and transaction.

Main parts that **BankApi** take care of are:

- **Account:** Represents the account of the customer.
- **Customer:** Represents customer.
- **CustomerAccount:**Represents needed data to open a new account.
- **Transaction:** Refers to the transaction done of a account.

## Technologies ##

- C#
- .NET Core (6.0)

## Quick Start ##

1. Clone the repository: `clone git@github.com:BassantAbdelaziz/BankApi.git`.
1. Launch the system.
1. Redirects to Swagger.

### Main Database ###
We have to trail:
1. Inset customers data into list and read directly by `GetCustomerById` method
1. `CustomerData.json` insert data into json file, read json, convert to list then read by `readCustomerFromJsonFile` method
