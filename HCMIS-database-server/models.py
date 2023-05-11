from dataclasses import dataclass
from enum import Enum


@dataclass
class Name:
    first_name: str
    middle_name: str
    last_name: str

    @property
    def fullname(self) -> str:
        if self.middle_name == "":
            return f"{self.first_name} {self.last_name}"
        
        return f"{self.first_name} {self.middle_name} {self.last_name}"


@dataclass
class Contact:
    email: str
    phone_number: str


@dataclass
class Account:
    username: str
    password: str


class Position(Enum):
    Admin = "Admin"
    Doctor = "Doctor"
    Nurse = "Nurse"
    Barangay_Health_Worker = "BHW"

    @staticmethod
    def from_str(s: str):
        match s:
            case "Admin":
                return Position.Admin
            case "Doctor":
                return Position.Doctor
            case "Nurse":
                return Position.Nurse
            case "Barangay Health Worker":
                return Position.Barangay_Health_Worker


@dataclass
class Employee:
    id: int
    name: Name
    contact: Contact
    account: Account
    position: Position

