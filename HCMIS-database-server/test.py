import requests


data = {
    "a": "a"
}

requests.post("http://192.168.100.9:5000/register", json=data)