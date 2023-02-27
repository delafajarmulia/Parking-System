SELECT m.Name , 
	m.TypeId , 
	m.Id , 
	m.Email , 
	m.PhoneNumber , 
	m.Address , 
	m.DateOfBirth , 
	m.Gender , 
    ms.Id AS MembershipId, 
	ms.Name AS NameMembership 
FROM     dbo.Members AS m LEFT OUTER JOIN
         dbo.MemberShipTypes AS ms ON m.TypeId = ms.Id