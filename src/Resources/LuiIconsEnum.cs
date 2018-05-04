﻿namespace leonardo.Resources
{
    public enum LuiIconsEnum
    {
        lui_icon_none,
        lui_icon_plus,
        lui_icon_calendar,
        lui_icon_menu,
        lui_icon_table,
        lui_icon_triangle_bottom,
        lui_icon_triangle_right,
        lui_icon_triangle_left,
        lui_icon_info,
        lui_icon_expression,
        lui_icon_bin,
        lui_icon_link,
        lui_icon_search,
        lui_icon_select_alternative,
        lui_icon_cross,
        lui_icon_sheet,
        lui_icon_stream,
        lui_icon_arrow_up,
        lui_icon_arrow_down,
        lui_icon_arrow_left,
        lui_icon_arrow_right,
        lui_icon_grid,
        lui_icon_list,
        lui_icon_ascending,
        lui_icon_descending,
        lui_icon_person,
        lui_icon_edit,
        lui_icon_tick

    }

    public static class LuiIconsEnumExtensions
    {
        public static string GetIconText(this LuiIconsEnum icon)
        {
            string icontext = "";
            switch (icon)
            {
                case LuiIconsEnum.lui_icon_none:
                    icontext = "";
                    break;
                case LuiIconsEnum.lui_icon_calendar:
                    icontext = "G";
                    break;
                case LuiIconsEnum.lui_icon_plus:
                    icontext = "P";
                    break;
                case LuiIconsEnum.lui_icon_menu:
                    icontext = "o";
                    break;
                case LuiIconsEnum.lui_icon_table:
                    icontext = "'";
                    break;
                case LuiIconsEnum.lui_icon_triangle_bottom:
                    icontext = "S";
                    break;
                case LuiIconsEnum.lui_icon_triangle_right:
                    icontext = "U";
                    break;
                case LuiIconsEnum.lui_icon_triangle_left:
                    icontext = "T";
                    break;
                case LuiIconsEnum.lui_icon_info:
                    icontext = "]";
                    break;
                case LuiIconsEnum.lui_icon_expression:
                    icontext = "3";
                    break;
                case LuiIconsEnum.lui_icon_bin:
                    icontext = "Ö";
                    break;
                case LuiIconsEnum.lui_icon_link:
                    icontext = "é";
                    break;
                case LuiIconsEnum.lui_icon_search:
                    icontext = "F";
                    break;
                case LuiIconsEnum.lui_icon_cross:
                    icontext = "‰";
                    break;
                case LuiIconsEnum.lui_icon_select_alternative:
                    icontext = "ö";
                    break;
                case LuiIconsEnum.lui_icon_sheet:
                    icontext = "4";
                    break;
                case LuiIconsEnum.lui_icon_stream:
                    icontext = "ã";
                    break;
                case LuiIconsEnum.lui_icon_arrow_down:
                    icontext = "¯";
                    break;
                case LuiIconsEnum.lui_icon_arrow_up:
                    icontext = "˜";
                    break;
                case LuiIconsEnum.lui_icon_arrow_left:
                    icontext = "ê";
                    break;
                case LuiIconsEnum.lui_icon_arrow_right:
                    icontext = "ë";
                    break;
                case LuiIconsEnum.lui_icon_grid:
                    icontext = "ì";
                    break;
                case LuiIconsEnum.lui_icon_list:
                    icontext = "î";
                    break;
                case LuiIconsEnum.lui_icon_ascending:
                    icontext = "≈";
                    break;
                case LuiIconsEnum.lui_icon_descending:
                    icontext = "∆";
                    break;
                case LuiIconsEnum.lui_icon_person:
                    icontext = "y";
                    break;
                case LuiIconsEnum.lui_icon_edit:
                    icontext = "@";
                    break;
                case LuiIconsEnum.lui_icon_tick:
                    icontext = "m";
                    break;
                default:
                    icontext = "";
                    break;
            }
            return icontext;

        }
    }
}