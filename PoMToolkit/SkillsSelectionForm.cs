using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PoMLibrary;

namespace PoMToolkit
{
    public partial class SkillsSelectionForm : Form
    {
        private string _entityClass;
        private Dictionary<int, int> _entitySkills;
        private Dictionary<int, Skill> _skills;

        private int _skillPtsLeft;

        private int _cost;

        public Dictionary<int, int> SelectedSkills
        {
            get { return _entitySkills; }
        }

        public int SkillPointsLeft
        {
            get { return _skillPtsLeft; }
        }

        public SkillsSelectionForm(Dictionary<int, Skill> skills, string entityClass, Dictionary<int, int> entitySkills, int skillPtsLeft)
        {
            InitializeComponent();

            _entityClass = entityClass;
            _entitySkills = entitySkills;

            _skillPtsLeft = skillPtsLeft;

            lblSkillPoints.Text = _skillPtsLeft.ToString();

            //load skills
            _skills = skills;

            foreach (Skill skill in _skills.Values)
            {
                if (skill.Costs.ContainsKey(_entityClass))
                    lstSkills.Items.Add(skill.Name);
            }

            //add entity skills to list
            if (_entitySkills != null)
            {
                foreach (int key in _entitySkills.Keys)
                {
                    foreach (Skill skill in _skills.Values)
                    {
                        if (skill.ID == key)
                            lstEntitySkills.Items.Add(skill.Name + " - " + _entitySkills[key].ToString());
                    }
                }
            }

            _cost = 0;
        }

        private void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cost = 0;

            if (lstSkills.SelectedIndex > -1)
            {
                foreach (Skill skill in _skills.Values)
                {
                    if (skill.Name == lstSkills.SelectedItem.ToString())
                    {
                        if (!int.TryParse(skill.Costs[_entityClass], out _cost))
                        {
                            //we probably have a case of a cost like "1/*" so get the first value from the string
                            int.TryParse(skill.Costs[_entityClass].Substring(0, skill.Costs[_entityClass].IndexOf("/")), out _cost);
                        }

                        txtDescription.Text = skill.Description;
                        lblCost.Text = skill.Costs[_entityClass];

                        break;
                    }
                }

                //cost should never equal 0 unless the skill's cost is in a bad format
                btnSelectSkill.Enabled = (lstSkills.SelectedIndex > -1 && _skillPtsLeft > _cost && _cost > 0);

            }
        }

        private void lstEntitySkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUnselectSkill.Enabled = (lstEntitySkills.SelectedIndex > -1);
        }

        private void btnSelectSkill_Click(object sender, EventArgs e)
        {
            //find the item in the selected skills list
            int loc;
            int numLevels;
            bool skillFound = false;

            for (int i = 0; i < lstEntitySkills.Items.Count; i++)
            {
                loc = lstEntitySkills.Items[i].ToString().IndexOf(" -");

                if (lstEntitySkills.Items[i].ToString().Substring(0, loc) == lstSkills.SelectedItem.ToString())
                {
                    numLevels = Convert.ToInt32(lstEntitySkills.Items[i].ToString().Substring(loc + 3));
                    numLevels++;
                    lstEntitySkills.Items[i] = lstSkills.SelectedItem.ToString() + " - " + numLevels.ToString();

                    _skillPtsLeft -= _cost;

                    lblSkillPoints.Text = _skillPtsLeft.ToString();

                    skillFound = true;

                    break;

                }
            }

            if (!skillFound)
            {
                lstEntitySkills.Items.Add(lstSkills.SelectedItem.ToString() + " - 1");

                _skillPtsLeft -= _cost;

                lblSkillPoints.Text = _skillPtsLeft.ToString();
            }
        }

        private void btnUnselectSkill_Click(object sender, EventArgs e)
        {
            int loc = lstEntitySkills.Items[lstEntitySkills.SelectedIndex].ToString().IndexOf(" -");

            foreach (Skill skill in _skills.Values)
            {
                if (skill.Name == lstEntitySkills.SelectedItem.ToString().Substring(0, loc))
                {
                    string classCost = skill.Costs[_entityClass];
                    int cost = 0;

                    if (!int.TryParse(classCost, out cost))
                        int.TryParse(classCost.Substring(0, classCost.IndexOf("/")), out cost);

                    if (cost > 0)
                    {
                        _skillPtsLeft += cost;
                        lblSkillPoints.Text = _skillPtsLeft.ToString();

                        int numLevels = Convert.ToInt32(lstEntitySkills.Items[lstEntitySkills.SelectedIndex].ToString().Substring(loc + 3));
                        numLevels--;
                        lstEntitySkills.Items[lstEntitySkills.SelectedIndex] = skill.Name + " - " + numLevels.ToString();
                    }

                    break;
                }
            }

        }

        private void btnOKCancel_Click(object sender, EventArgs e)
        {
            //set the skills dictionary object if selection has been OK'd
            if (this.DialogResult == DialogResult.OK)
            {
                string skillName;
                int loc;
                int levels;

                if (_entitySkills == null)
                    _entitySkills = new Dictionary<int, int>();

                for (int i = 0; i < lstEntitySkills.Items.Count; i++)
                {
                    loc = lstEntitySkills.Items[i].ToString().IndexOf(" -");

                    skillName = lstEntitySkills.Items[i].ToString().Substring(0, loc);

                    foreach (Skill skill in _skills.Values)
                    {
                        if (skill.Name == skillName)
                        {
                            levels = Convert.ToInt32(lstEntitySkills.Items[i].ToString().Substring(loc + 3));

                            if (_entitySkills.ContainsKey(skill.ID))
                                _entitySkills[skill.ID] = levels;
                            else
                                _entitySkills.Add(skill.ID, levels);

                            break;
                        }
                    }
                }
            }

            this.Hide();
        }
    }
}
