import boto3
s3=boto3.resource('s3')
#AWS available resource are:
# cloudformation, cludwatch, dynamodb, ec3, glacier, iam, opswords, S3, sns, sqs.

backets=s3.buckets.all()
for bucket in buckets:
    print(bucket.name) 

#you write some script to connect to AWS and do somethongs.

#pip install awscli
# aws configure
# AWS access key
#you control your AWS from your terminal

# AWS Access Key ID [None]: AKIAIZLQVC724OPSKQAA
# AWS Secret Access Key [None]: pmKTGgEyDzJ2AHF+KPkexDXEeHA7MAaEqbzLWvuM
# Default region name [None]:
# Default output format [None]:

#aws s3 ls
#aws iam list-users --output table

 #IMS Identity Access Management for AWS. 

# aws ec2
 
import boto3
import json
 
iab = boto3.client('iam')
reponse = iam.create_user(UserName='newUser')
print(response)
 
 