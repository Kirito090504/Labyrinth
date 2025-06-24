import sys
from dataclasses import dataclass
from enum import Enum 
import os
import shutil
import textwrap
from typing import Dict
from typing import Union

def clearScreen() -> None:
    os.system("cls" if os.name == "nt" else "clear")

def confirm(message: str = "Press enter to continue...") -> None:
    input(message)

class InputBox:
    """
    Show an input box to the user and return their input.
    """

    def __init__(
        self,
        title: str = "Automated Teller Machine",
        description: Union[str, None] = None,
        margin: int = 4,
        title_fill_char: str = ' ',
        clear_screen: bool = True,
        input_prompt: str = " >>> "
    ):
        """
        Initialize the InputBox() class.

        :param title: The title of the input box. (default: <info.title>)
        :param description: The description of the input box. (default: None)
        :param margin: The margin of the description. (default: 4)
        :param title_fill_char: The character to fill the sides of the title with. (default: ' ')
        :param clear_screen: Whether to clear the screen before showing the dialog. (default: True)
        :param input_prompt: The prompt to show beside the user's input field. (default: " >>> ")
        """

        self.title = title
        self.description = description
        self.margin = margin
        self.title_fill_char = title_fill_char
        self.clear_screen = clear_screen
        self.input_prompt = input_prompt

    def __call__(self) -> str:
        """
        Show the dialog to the user and return their input.

        :returns: The input of the user.
        """

        if self.clear_screen:
            clearScreen()

        print(self.__buildDialog())
        return input(self.input_prompt)

    def __str__(self) -> str:
        """
        Get a string representation of the dialog.
        This will not clear the screen nor ask for the user's input.

        :returns: The string representation of the dialog.
        """

        return self.__buildDialog()

    def __buildDialog(self) -> str:
        """
        Build the dialog.

        :returns: The dialog.
        """

        # Center and add the title.
        result: str = f"\n{self.title.center(shutil.get_terminal_size().columns, self.title_fill_char)}\n\n"
        if self.description is not None:  # Center and add the description.
            for desc_line in self.description.split('\n'):
                for line in textwrap.wrap(
                    desc_line,
                    shutil.get_terminal_size().columns - (self.margin * 2)
                ):
                    result += f"{line.center(shutil.get_terminal_size().columns)}\n"

            result += '\n'

        return result


class Choices:
    """
    Show a menu of choices to the user and return the choice they make.
    """

    def __init__(
        self,
        list_of_choices: Dict[str, str],
        title: str = "Automated Teller Machine",
        description: Union[str, None] = None,
        minimum_spaces: int = 1,
        margin: int = 4,
        title_fill_char: str = ' ',
        clear_screen: bool = True,
        case_sensitive: bool = False,
        input_prompt: str = " >>> "
    ):
        """
        Initialize the Choice() class.

        :param list_of_choices: A dictionary containing the ID and description of each choice.
        :param title: The title of the choice dialog. (default: <info.title>)
        :param description: A description about the choice dialog. (default: None)
        :param minimum_spaces: The minimum number of spaces between the ID and description. (default: 1)
        :param margin: The margin of the description. (default: 4)
        :param title_fill_char: The character to fill the sides of the title with. (default: ' ')
        :param clear_screen: Whether to clear the screen before showing the dialog. (default: True)
        :param case_sensitive: Whether to ignore case when comparing the user's input to the IDs. (default: False)
        :param input_prompt: The prompt to show beside the user's input field. (default: " >>> ")
        """

        self.list_of_choices = list_of_choices

        self.title = title
        self.description = description
        self.minimum_spaces = minimum_spaces

        self.margin = margin
        self.title_fill_char = title_fill_char
        self.clear_screen = clear_screen
        self.case_sensitive = case_sensitive
        self.input_prompt = input_prompt

    def __call__(self, prompt_only: bool = False) -> str:
        """
        Show the dialog to the user and return the choice they make.

        :returns: The choice the user made.
        """

        while True:
            if self.clear_screen:
                clearScreen()

            if not prompt_only:
                print(self.__buildDialog())

            choice = input(self.input_prompt)  # Get the user's choice.
            if self.case_sensitive:
                if choice in self.list_of_choices.keys():
                    return choice

            else:
                if choice.lower() in [  # Convert the keys to lowercase ONLY IF the key is a string.
                    key.lower() if type(key) is str else key
                    for key in self.list_of_choices.keys()
                ]:
                    return choice

    def __str__(self) -> str:
        """
        Get a string representation of the dialog.
        This will not clear the screen nor ask for the user's input.

        :returns: The string representation of the dialog.
        """

        return self.__buildDialog()

    def __buildDialog(self) -> str:
        """
        Build the dialog.
        """

        # Center and add title.
        result: str = f"\n{self.title.center(shutil.get_terminal_size().columns, self.title_fill_char)}\n\n"

        if self.description is not None:  # Center and add description.
            for desc_line in self.description.split('\n'):
                for line in textwrap.wrap(
                    desc_line,
                    shutil.get_terminal_size().columns - (self.margin * 2)
                ):
                    result += f"{line.center(shutil.get_terminal_size().columns)}\n"

            result += '\n'

        result += self.getChoicesList()
        result += '\n'
        return result

    def getChoicesList(self) -> str:
        """
        Return a string containing the formatted choices list without the title and description.
        """

        result: str = ""

        # Get the longest key; to be used in formatting the choices.
        longest_id = max(
            (len(key) if key is not None else 0)
            for key in self.list_of_choices.keys()
        )

        # Format and add choices to result.
        for choice_id, choice_description in self.list_of_choices.items():
            spacer = ' ' * (self.minimum_spaces + (longest_id - len(str(choice_id))))
            result += f"[{choice_id}]{spacer}{choice_description}\n"

        return result

class Account:
    def __init__(self, name, number, account_type):
        self.name = name
        self.number = number
        self.account_type = account_type
        self.balance = 500000

    def deposit(self, amount):
        self.balance += amount

    def withdraw(self, amount):
        if amount <= self.balance:
            self.balance -= amount
        else:
            print("Insufficient funds")

    def show_balance(self):
        print(f"Current balance: {self.balance}")
        confirm()

def atm_transaction():
    name = InputBox(description="Enter Account Name: ")()
    number = InputBox(description="Enter Account Number: ")()
    account_type = Choices(list_of_choices={"S":"Savings","C":"Checking"}, description="Select account type: ")()

    account = Account(name, number, account_type)

    while True:
       
        choice = Choices({"1": "Deposit", "2": "Withdraw","3": "Balance" ,"4": "Cancel"}, description="Select Transaction: ")()

        if choice == '1':
            amount = float(InputBox(description="Enter Amount to Deposit: ")())
            confirm = InputBox(description="Confirm Deposit Amount (Y/N): ")()

            if confirm.lower() == 'y':
                account.deposit(amount)
                account.show_balance()
        elif choice == '2':
            amount = float(InputBox(description="Enter Amount to Withdraw: ")())
            confirm = InputBox(description="Confirm Withdrawal Amount (Y/N): ")()

            if confirm.lower() == 'y':
                account.withdraw(amount)
                account.show_balance()

        elif choice == '3':
                account.show_balance()
            

        elif choice == '4':
            confirm = InputBox(description="Confirm Cancel (Y/N): ")()

            if confirm.lower() == 'y':
                break

        another_transaction = InputBox(description="Do you want another transaction? (Yes/No): ")()
        if another_transaction.lower() != 'y':
            break

atm_transaction()