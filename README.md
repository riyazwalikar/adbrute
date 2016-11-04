# ADBrute

## Requirements
- Microsoft Visual Studio 2013 for Desktop
- Microsoft .NET Runtime 3.0 above
- Run ADBrute.vbproj
- Compile or Run using the IDE
<br />
<br />
## About
ADBrute allows you to test the security of users in an Active Directory Environment. When the domain policy causes the login password of a domain user to expire or when the user account is locked due to incorrect logins, the domain administrator may reset the password to the default password based on company policy. Many users do not change the default password after it has been reset by the administrator. This creates a major security hole in the domain environment.
<br /><br />
A malicious user could easily use the default password to login into the victim's user accounts, delete, read and send mails or access other resources on the network.
<br /><br />
ADBrute allows you to scan the entire Active Directory for users who still have the default password. You can then issue warnings or reminders to the users to change their passwords. You may be surprised at the number of users that an organization has who do not change their passwords after it has been reset by the domain administrators.
<br /><br />
## Usage
ADBrute is simple to use: 

1. Run ADBrute.
2. Enter the name of the domain controller and valid login credentials to connect to the Active Directory. The user can be any user on the domain.
3. Click on Login and wait till the entire user list for your organization is populated from the AD.
4. You can double click on a User to view additional information.
5. Enter the default password for your organization and press the start button.
6. Sit back until the program scans and enumerates users who use the default password.
7. You can export both the lists, the entire user list as well as the weak user list to three different file formats, .csv, .txt and .xls.
<br />
<br />
## Known Issues

1. Multiple executions of ADBrute may cause account lockouts if the number of attempts to a login have passed (usually 3). The maximum login attempt is an administrative domain policy and may differ with different organizations.
2. ADBrute will not enumerate users whose account is locked or disabled even though they may have the default password, although the users will be enumerated in the All Users list.
