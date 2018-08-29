"""
Questions (15 minutes) / Oral

Give an example of professional experience that shows you're fit for the position.
What are your three main skills?
What area do you think you should improve?
What documentation do you produce?
How do you test your code?

Quiz (30 minutes)

Please think aloud to make it easier to follow the thought process.
NOTE: Changes to the document are seen real time by the interviewer.

   make a list of even numbers from 0 to 10 included
"""

#list = foreach i in range[1, 10]
list = []
for i in range(11):
    if i % 2 == 0:
        list.append(i)
print(list)

# ****************

""" Using the sample dataframe below, return a dataframe with 
*   the number of times a user had points and 
*   the total number of points
"""
import pandas as pd

f=pd.DataFrame({'User': ['Frank', 'Elisa', 'Frank', 'John', 'John', 'Anna'],
              'Points': [2, 1, 5, 3, 1, 0]})

newtable = {}
i = 0
for use in f['User']:        
    point = f['Points'][i]
    newtable.setdefault(use,[]).append(point)
    i = i+1
    
print(newtable)

# ************************


""" Implement a function to store the hash of a text in a sqlite3 table and 
return the hash value
*   text_value: text to hash
"""    

"""
To access dictionary elements, you can use the familiar square brackets along with the key to obtain its value.
# Declare a dictionary 
dict = {'Name': 'Zara', 'Age': 7, 'Class': 'First'}

# Accessing the dictionary with its key
print "dict['Name']: ", dict['Name']
print "dict['Age']: ", dict['Age']

"""

import sqlite3
import time
import random
import datetime

conn = sqlite3.connect("hashtable") #if no db will be created.
c = conn.cursor()
def create_table():
    
    c.execute('CREATE TABLE IF NOT EXISTS hashTable(key TEXT, value REAL)')
    
def data_entry():
    
    key = str(datetime.datetime.fromtimestamp(time.time()).strftime('%Y-%m-%d %H:%M:%S'))
    value = random.randrange(0,10)   
    c.execute("INSERT INTO hashTable VALUES(?, ?)", (key, value))
    conn.commit()
    
    #conn.close()
    
def data_read_db():
    c.execute('SELECT * FROM hashTable')    
    for row in c.fetchall(): 
        print(row)
    c.close()
    conn.close()    

# Download DB Browser for SQLLite 3.8.0        
create_table()
data_entry()
data_read_db()

# *******************************

import json
import requests
import pandas as pd

def web_api(start_year, end_year):
    """ Return values from web api call
    *   start_year: string with format YYYY
    *   end_year: string with format YYYY
    Based on: https://www.bls.gov/developers/api_python.htm
    """
"""    
    headers = {'Content-type': 'application/json'}
    data = json.dumps({"seriesid": ['CUUR0000SA0','SUUR0000SA0'],
                       "startyear":start_year, "endyear":end_year})
    p = requests.post('https://api.bls.gov/publicAPI/v2/timeseries/data/',
                      data=data, headers=headers)
    json_data = json.loads(p.text)
    # code here to return a pandas dataframe from json_data
    return "DataFrame with data"
"""

import requests
import json
import prettytable
import pandas as pd

headers = {'Content-type': 'application/json'}
data = json.dumps({"seriesid": ['CUUR0000SA0','SUUR0000SA0'],"startyear":"2008", "endyear":"2018"})
p = requests.post('https://api.bls.gov/publicAPI/v2/timeseries/data/', data=data, headers=headers)
json_data = json.loads(p.text)

train = pd.DataFrame.from_dict(json_data, orient='index')
print(train)
    
""" Using the function implemented above, execute it on the column which
has free form text.
Call the web_api for the last 10 full years.
"""

# **************************

""" Create a function providing all the code values from 
the table created above.

Bonus point for returning a dataframe with columns ['seriesID',
'year', 'periodName', 'code']
"""

for series in json_data['Results']['series']:
    x=prettytable.PrettyTable(["series id","year","period","value","footnotes"])
    seriesId = series['seriesID']
    for item in series['data']:
        year = item['year']
        period = item['period']
        value = item['value']
        footnotes=""
        for footnote in item['footnotes']:
            if footnote:
                footnotes = footnotes + footnote['text'] + ','

    print('series: ', seriesId)
    print('year: ', year)
    print('period: ', period)
    print('value: ', value)
    print('footnotes: ', footnotes)
    
# **************************