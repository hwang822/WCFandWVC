#https://www.youtube.com/watch?v=OT5qJBINiJY

# SQLAlchemy to access db
# pip install SQLAlchemy
from SQLAlchemy import create_engine
engine = create_engine('sgllite:////imcrry)

connection = engine.connect()
result = connection.execute("select username from users")
for row in result:
    print("username:", row['username'])
connection.close()

def method_a(connection):
    trans = connection.begin() # open a transaction
    try:
        method_b(connection)
        trans.commit()  # transaction is committed here
    except:
        trans.rollback() # this rolls back the transaction unconditionally
        raise

# method_b also starts a transaction
def method_b(connection):
    trans = connection.begin() # open a transaction - this runs in the context of method_a's transaction
    try:
        connection.execute("insert into mytable values ('bat', 'lala')")
        connection.execute(mytable.insert(), col1='bat', col2='lala')
        trans.commit()  # transaction is not committed yet
    except:
        trans.rollback() # this rolls back the transaction unconditionally
        raise
