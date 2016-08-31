from flask import Flask, request
app = Flask(__name__)

@app.route("/")
def hello():
  print("Client sent username: " +
    request.cookies.get('username'))
  return "Hello World!"

@app.route("/login", methods=['POST'])
def login():
  print("user logged in with " +
    request.form['username'] +
    "/" +
    request.form['password'])
  return "Login successful!"

if __name__ == "__main__":
   app.run()