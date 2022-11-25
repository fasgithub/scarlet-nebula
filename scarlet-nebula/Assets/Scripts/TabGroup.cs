using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> tabButtons;
    public TabButton selectedTab;
    
    public void Subscribe(TabButton button)
    {
        if(tabButtons == null)
        {
            tabButtons = new List<TabButton>();
        }
        
        tabButtons.Add(button);
    }
    
    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
        {
            button.background.color = new Color(button.background.color.r,button.background.color.g,button.background.color.b, 0.15f);   
        }
    }
    
    public void OnTabExit(TabButton button)
    {
        ResetTabs();
    }
    
    public void OnTabSelected(TabButton button)
    {
        selectedTab = button;
        ResetTabs();
        button.background.color = new Color(button.background.color.r,button.background.color.g,button.background.color.b, 0.15f);
    }
    
    public void ResetTabs()
    {
        foreach(TabButton button in tabButtons)
        {
            if (selectedTab != null && button == selectedTab) { continue; }
            button.background.color = new Color(button.background.color.r,button.background.color.g,button.background.color.b, 0);
        }
    }
}
