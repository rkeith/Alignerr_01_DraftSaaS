
Public Class DevMenu

    Public Function getMenuTree() As MenuTree
        Dim mTree As New MenuTree
        mTree.AccountName = "Genera IVF"
        mTree.UserID = 22
        mTree.IsAdmin = True
        mTree.HomeSiteID = 1
        Dim nSites As New List(Of MenuSite)
        Dim nSite As New MenuSite
        nSite.SiteID = 1
        nSite.SiteName = "Stratford"
        Dim nGroups As New List(Of MenuReportingGroup)
        Dim nGroup As New MenuReportingGroup
        nGroup.ReportingGroupID = 1
        nGroup.ReportingGroupName = "Stratford Incubators"
        nGroups.Add(nGroup)
        nSite.SiteReportingGroups = nGroups
        nSites.Add(nSite)


        Dim nSite1 As New MenuSite
        nSite1.SiteID = 2
        nSite1.SiteName = "Cambridge"
        Dim nGroups1 As New List(Of MenuReportingGroup)
        Dim nGroup1 As New MenuReportingGroup
        nGroup1.ReportingGroupID = 2
        nGroup1.ReportingGroupName = "Cambridge Incubators"
        nGroups1.Add(nGroup1)
        nSite1.SiteReportingGroups = nGroups1
        nSites.Add(nSite1)

        Dim nSite2 As New MenuSite
        nSite2.SiteID = 3
        nSite2.SiteName = "Milton Keynes"
        Dim nGroups2 As New List(Of MenuReportingGroup)
        Dim nGroup2 As New MenuReportingGroup
        nGroup2.ReportingGroupID = 3
        nGroup2.ReportingGroupName = "Milton Keynes Incubators"
        nGroups2.Add(nGroup2)
        nSite2.SiteReportingGroups = nGroups2
        nSites.Add(nSite2)

        Dim nSite3 As New MenuSite
        nSite3.SiteID = 4
        nSite3.SiteName = "Hemel Hempstead"
        Dim nGroups3 As New List(Of MenuReportingGroup)
        Dim nGroup3 As New MenuReportingGroup
        nGroup3.ReportingGroupID = 4
        nGroup3.ReportingGroupName = "Hemel Hempstead Incubators"
        nGroups3.Add(nGroup3)
        nSite3.SiteReportingGroups = nGroups3
        nSites.Add(nSite3)


        mTree.Sites = nSites


        Return mTree

    End Function


End Class


Public Class MenuReportingGroup

    Public ReportingGroupID As Integer = 0
    Public ReportingGroupName As String = ""
    'Public ReportingGroupEquipment As List(Of MenuEquipment)

End Class

Public Class MenuSite

    Public SiteID As Integer = 0
    Public SiteName As String = ""
    Public SiteReportingGroups As List(Of MenuReportingGroup)
    'Public SiteEquipment As List(Of MenuEquipment)
    'Public SiteDevices As List(Of MenuDevice)
    'Public SiteRelays As List(Of MenuRelay)

End Class

Public Class MenuTree

    Public AccountName As String = ""
    Public UserID As Index = 1
    Public IsAdmin As Boolean = False
    Public HomeSiteID As Integer = 1
    Public Sites As List(Of MenuSite)

End Class