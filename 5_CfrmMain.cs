/* CSIS2664, 2023
 * Test 1, Question 5
 * Student number:2020536070
 * Surname, Initials: Ntshele A
 */

using System;
using System.Windows.Forms;

namespace Bikes
{
    public partial class CfrmMain : Form
    {
        public CfrmMain()
        {
            InitializeComponent();

            //Build bike types
            IBikeBuilder roadBikeBuilder = new RoadbikeBuilder();
            Biketype roadBike = roadBikeBuilder.GetBiketype();

            IBikeBuilder mountainBikeBuilder = new MountainbikeBuilder();
            Biketype mountainBike = mountainBikeBuilder.GetBiketype();

            IBikeBuilder commuterBikeBuilder = new CommuterbikeBuilder();
            Biketype commuterBike = commuterBikeBuilder.GetBiketype();

            IBikeBuilder touringBikeBuilder = new TouringbikeBuilder();
            Biketype touringBike = touringBikeBuilder.GetBiketype();

            //Add types to listbox
            lstbxTypes.Items.Add(roadBike);
            lstbxTypes.Items.Add(mountainBike);
            lstbxTypes.Items.Add(commuterBike);
            lstbxTypes.Items.Add(touringBike);

            //Listbox for bike types
            lstbxTypes.DisplayMember = "Type";
        } //ctor

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        } //btnClose_Click

        private void lstbxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Biketype type = (Biketype)lstbxTypes.SelectedItem;
            lblPurpose.Text = type.Purpose.ToString();
            lblWheels.Text = type.WheelsTyres.ToString();
            lblSuspension.Text = type.Suspension.ToString();
            lblGears.Text = type.Gears.ToString();
            lblSeating.Text = type.Seating.ToString();
            lblHandles.Text = type.Handles.ToString();
            lblAccessories.Text = type.Accessories.ToString();
        } //lstbxTypes_SelectedIndexChanged

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string s = "";

            foreach (Biketype type in lstbxTypes.Items)
            {
                s += type.ToString() + "\r\n";
            } //foreach type

            CdlgOutput dlg = new CdlgOutput(s);
            dlg.ShowDialog();

        } //btnPrint_Click
    } //class CfrmMain
} //namespace

