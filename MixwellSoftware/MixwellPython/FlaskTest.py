#Flask is apps to work at web applicatons at back server

from flask import Flask, redirect, render_template
app = Flask(__name__) 

    
@app.route('/a-redirect')
def a_redirect():
    """Redirect the user"""
    return redirect("www.cnn.com")

@app.route('/a-template')    
def a_template():
    """Redirect a page using a Jinga2 template"""
    return render_template('a_template')
    
#run Python FlaskTest.py
#it runing web service at localhost.
#type localhost:5000 to see this web server html page 