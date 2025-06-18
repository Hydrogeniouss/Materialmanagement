using application.A_PL.Cards;
using application.B_BL;
namespace application.A_PL;

public partial class MemberReturnView : Form
{

    private void FillRents(List<Rent> rents)
    {
        sct_rentMaterial.Panel1.Controls.Clear(); // Clear existing controls
        List<RentCard> rentCards = new(rents.Select(rent => new RentCard(rent)));
        for (var i = 0; i < rentCards.Count; i++)
        {
            RentCard rc = rentCards[i];
            rc.Location = new Point(Card.MARGIN, (RentCard.STANDARDHEIGHT + Card.MARGIN) * i + Card.MARGIN);
            if (rc.BackColor == RentCard.STANDARDBACKCOLOR) rc.Click += RentCard_Click;
            sct_rentMaterial.Panel1.Controls.Add(rc);
        }
    }

    private void RentCard_Click(object? sender, EventArgs e)
    {
        if (sender is RentCard rct)
        {
            if (rct.Parent == sct_rentMaterial.Panel1)
            {
                if (rct.BackColor == MaterialCardLarge.STANDARDBACKCOLOR)
                {
                    rct.BackColor = UIConfig.GREEN;
                    //TODO fix placements (buggy when scrolling starts working)
                    int itemsCount = sct_rentMaterial.Panel2.Controls.OfType<Card>().Count();
                    RentCardSmall rcs = new RentCardSmall(rct)
                    {
                        Location = new Point(Card.MARGIN, (Card.STANDARDHEIGHT + Card.MARGIN) * itemsCount + Card.MARGIN)
                    };

                    rcs.Click += RentCard_Click;
                    rcs.btn_Delete.Click += RentCard_Click; //TODO: Doesnt Work, why??

                    sct_rentMaterial.Panel2.Controls.Add(rcs);

                    UpdateCards();
                }

                else
                {
                    rct.BackColor = RentCard.STANDARDBACKCOLOR;

                    sct_rentMaterial.Panel2.Controls.Remove(
                        sct_rentMaterial.Panel2.Controls.OfType<RentCardSmall>().Where(
                            rcs => rcs.Origin == rct).ToArray()[0]
                    );

                    UpdateCards();
                }
            }

        }
        else if (sender is Button btn)
        {
            RentCardSmall rcs = (RentCardSmall)btn.Parent!;
            if (rcs.Parent == sct_rentMaterial.Panel2)
            {
                rcs.Origin.BackColor = Color.LightGray;
                rcs.Click -= RentCard_Click;
                rcs.btn_Delete.Click -= RentCard_Click;
                sct_rentMaterial.Panel2.Controls.Remove(rcs);

                UpdateCards();
            }
        }
    }
    private void UpdateCards()
    {
        List<Card> cards = sct_rentMaterial.Panel1.Controls.OfType<Card>().ToList();
        for (int i = 0; i < cards.Count; i++)
        {
            Card card = cards[i];

            card.Location = new Point(Card.MARGIN, (card.Height + Card.MARGIN) * i + Card.MARGIN);
        }

        cards = sct_rentMaterial.Panel2.Controls.OfType<Card>().ToList();
        for (int i = 0; i < cards.Count; i++)
        {
            Card card = cards[i];
            card.Location = new Point(Card.MARGIN, (card.Height + Card.MARGIN) * i + Card.MARGIN);
        }
    }


    public MemberReturnView(int memberId)
    {
        InitializeComponent();
        _memberId = memberId;
        FillRents(Rent.FromDatabase(true, _memberId));
    }

    private int _memberId;

    public int MemId { get; set; }

    private void ReturnView_Load(object sender, EventArgs e)
    {
        btn_return.Text = $"Zurückgeben\n({DateTime.Now})";

        List<Rent> rentData = Rent.FromDatabase(true, _memberId);
    }

    private void lbl_borrow_Click(object sender, EventArgs e)
    {
        new MemberRentView(_memberId).Show();
        UiHelper.ProxyClose(this);
    }

    private void MemberReturnView_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (!UiHelper.ProgramaticallyClosing)
        {
            UiHelper.ProxyExit();
        }
        else
        {
            UiHelper.ProgramaticallyClosing = false; // Reset for next use
        }

    }

    private void btn_return_Click(object sender, EventArgs e)
    {
        foreach (RentCardSmall rcs in sct_rentMaterial.Panel2.Controls.OfType<RentCardSmall>())
        {
            rcs.Origin.OriginRent.Return();
            Material mat = rcs.Origin.OriginMaterial;
            mat.AmountAvailable += rcs.Origin.OriginRent.Quantity;
            mat.UpdateOnDatabase();
        }
        FillRents(Rent.FromDatabase(true, _memberId));
        sct_rentMaterial.Panel2.Controls.Clear();
    }


    /* Preset for try catch for database access @marnie
            try
            {
                //DB Access
            }
            catch (Exception ex)
            {
                if (DialogResult.Retry == MessageBox.Show("Daten konnten nicht geladen werden. Fehler:\n" + ex.Message, "Fehler", MessageBoxButtons.RetryCancel))
                {
                    // Method call for the method this code is in itself
                }
                return;
            }
    */
}

