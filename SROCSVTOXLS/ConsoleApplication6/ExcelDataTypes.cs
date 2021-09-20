using OfficeOpenXml;

namespace SROCSVTOXLS
{
    class ExcelDataTypes
    {
        private static eDataTypes[] _rsctDT;
        private static eDataTypes[] _aplDT;
        private static eDataTypes[] _ccgDT;
        private static eDataTypes[] _ccgPesDT;
        private static eDataTypes[] _ccgCOLDT;
        private static eDataTypes[] _OBJDT;
        private static eDataTypes[] _COBDT;
        private static eDataTypes[] _PESDT;
        private static eDataTypes[] _RSCTRMDT;
        private static eDataTypes[] _RSCTCIADT;
        private static eDataTypes[] _SNDOCDT;
        private static eDataTypes[] _DataType_FRANQ;
        private static eDataTypes[] _OBJSEGDT;

        #region PREMIO
        public static eDataTypes[] DataType_APL
        {
            get
            {
                if (_aplDT == null)
                {
                    _aplDT = new eDataTypes[] {
                        eDataTypes.String,//id_trans						
                        eDataTypes.Number,//nr_emp
                        eDataTypes.String,//cd_susep
                        eDataTypes.String,//nr_apolice
                        eDataTypes.Number,//nr_seq
                        eDataTypes.Number,//max_limit
                        eDataTypes.Number,//csa_premium
                        eDataTypes.DateTime,//dt_proposta_assinatura
                        eDataTypes.String//ds_motivo_endosso
                    };
                }
                return _aplDT;
            }
        }


        public static eDataTypes[] DataType_OBJ
        {

            get
            {

                if (_OBJDT == null)
                {
                    _OBJDT = new eDataTypes[] {
                       eDataTypes.String,// sistema_origem  
                        eDataTypes.Number,//nr_emp  
                        eDataTypes.String,//id_trans    
                        eDataTypes.String,//id_trans_apolice    
                        eDataTypes.String,//tp_objeto   
                        eDataTypes.String,//tp_objeto_descr 
                        eDataTypes.String,//cd_objeto   
                        eDataTypes.String,//descr_objeto    
                        eDataTypes.String,//cd_origem_risco 
                        eDataTypes.String,//uf_risco    
                        eDataTypes.String,//cep_risco   
                        eDataTypes.String,//pais_risco  
                        eDataTypes.String,//nr_contrato 
                        eDataTypes.Number,//vl_objeto_segurado  
                        eDataTypes.String,//cd_identificacao
                    };
                }
                return _OBJDT;

            }
        }


        public static eDataTypes[] DataType_COB
        {

            get
            {

                if (_COBDT == null)
                {
                    _COBDT = new eDataTypes[] {
                        eDataTypes.String, //ID_TRANS_APOLICE   
                        eDataTypes.Number,//nr_emp
                        eDataTypes.String,//cd_susep
                        eDataTypes.String,//nr_apolice
                        eDataTypes.Number,//nr_seq
                        eDataTypes.String,//cd_objeto
                        eDataTypes.String,//cd_cobertura   
                        eDataTypes.String,//descr_cobertura
                        eDataTypes.String,//cd_cobertura_susep
                        eDataTypes.String,//tp_caracteristica
                        eDataTypes.String,//tb_cobertura
                        eDataTypes.String,//op_segundo_risco
                        eDataTypes.String//tp_base_indeniz
                    };
                }
                return _COBDT;

            }
        }

        public static eDataTypes[] DataType_FRANQ
        {

            get
            {

                if (_DataType_FRANQ == null)
                {
                    _DataType_FRANQ = new eDataTypes[] {
                        eDataTypes.String, //sistema_origem
                        eDataTypes.Number,//nr_emp
                        eDataTypes.String,//id_trans
                        eDataTypes.String,//id_trans_cobertura
                        eDataTypes.String,//tp_franquia
                        eDataTypes.String,//descr
                        eDataTypes.Number,//vl_franquia
                        eDataTypes.String,//tp_participacao
                        eDataTypes.String,//descr_participacao
                        eDataTypes.Percent,//pct_participacao
                        eDataTypes.Number,//vl_min_participacao
                        eDataTypes.Number,//vl_max_participacao
                        eDataTypes.Number,//prazo_franquia
                        eDataTypes.String//op_dia_util
                    };
                }
                return _DataType_FRANQ;

            }
        }


        public static eDataTypes[] DataType_PES
        {

            get
            {

                if (_PESDT == null)
                {
                    _PESDT = new eDataTypes[] {
                        eDataTypes.Unknown, //id_trans
                        eDataTypes.Number,//nr_emp
                        eDataTypes.Number,//cd_susep
                        eDataTypes.String,//nr_apolice
                        eDataTypes.Number,//nr_seq
                        eDataTypes.String,//cd_funcao
                        eDataTypes.String,//tpp
                        eDataTypes.String,//cp
                        eDataTypes.String,//nome
                        eDataTypes.String,//endereco
                        eDataTypes.String,//complemento
                        eDataTypes.String,//bairro
                        eDataTypes.String,//cidade	
                        eDataTypes.String,//uf	
                        eDataTypes.String,//cep	
                        eDataTypes.String,//pais_nac
                        eDataTypes.String,//tp_direito
                        eDataTypes.String,//tp_exp_politica
                        eDataTypes.String,//email
                    };
                }
                return _PESDT;

            }
        }
        #endregion

        #region RSCT
        public static eDataTypes[] DataType_RSCT
        {
            get
            {
                if (_rsctDT == null)
                {
                    _rsctDT = new eDataTypes[] {
                            eDataTypes.Unknown, //1.nr_emp	
                            eDataTypes.Number, //2.id_trans	
                            eDataTypes.String,//3.cd_contrato	
                            eDataTypes.String,//4.dt_ref	
                            eDataTypes.Number,//5.tp_contrato	
                            eDataTypes.Number,//6.tp_forma	
                            eDataTypes.Number,//7.mod_rsg
                            eDataTypes.DateTime,//8.dt_ini_vig	
                            eDataTypes.DateTime,//9.dt_fim_vig	
                            eDataTypes.Unknown,//10.tp_cobertura	
                            eDataTypes.Unknown,//11tp_forma_cobertura	
                            eDataTypes.Unknown,//12cd_base_cessao	
                            eDataTypes.Number,//13vl_retencao_max	
                            eDataTypes.Unknown,//14op_ret_variavel	
                            eDataTypes.Number,//15vl_capacidade_max
                            eDataTypes.Unknown,//16op_cap_variavel	
                            eDataTypes.Number,//17vl_capacidade_max	
                            eDataTypes.Unknown,//18op_cap_variavel
                            eDataTypes.Number,//19vl_premio_estimado	
                            eDataTypes.Unknown,//20cd_moeda	
                            eDataTypes.Percent,//21pct_cedido	
                            eDataTypes.Unknown,//22op_quota_variavel	
                            eDataTypes.Unknown,//23op_part_lucro	
                            eDataTypes.Number,//24id_trans_apolice	
                            eDataTypes.Unknown,//25vig_media_dia
                    };
                }
                return _rsctDT;
            }
        }

        public static eDataTypes[] DataType_RSCTRM
        {

            get
            {

                if (_RSCTRMDT == null)
                {
                    _RSCTRMDT = new eDataTypes[] {
                        eDataTypes.Unknown, //sistema_origem	
                        eDataTypes.Number,//nr_emp	
                        eDataTypes.String,//id_trans	
                        eDataTypes.String,//id_trans_contrato	
                        eDataTypes.String,//cd_ramo_susep	
                        eDataTypes.String,//descr_ramo
                   };
                }
                return _RSCTRMDT;

            }
        }

        public static eDataTypes[] DataType_RSCTCIA
        {

            get
            {

                if (_RSCTCIADT == null)
                {
                    _RSCTCIADT = new eDataTypes[] {
                        eDataTypes.Unknown /*nr_empre*/,
                        eDataTypes.Number /*id_trans*/,
                        eDataTypes.String /*id_trans_contrato*/,
                        eDataTypes.String /*cd_susep*/,
                        eDataTypes.Number /*tp_cia*/,
                        eDataTypes.String /*cp*/,
                        eDataTypes.String /*nome*/,
                        eDataTypes.Number /*nr_faixa*/,
                        eDataTypes.Number /*vl_max_faixa*/,
                        eDataTypes.Percent /*pct_participacao*/
                   };
                }
                return _RSCTCIADT;
            }
        }
        #endregion

        #region CCG
        public static eDataTypes[] DataType_CCG
        {
            get
            {
                if (_ccgDT == null)
                {
                    _ccgDT = new eDataTypes[] {
                        eDataTypes.String,//SISTEMA_ORIGEM;
                        eDataTypes.Number,//NR_EMP;
                        eDataTypes.String,//ID_TRANS;
                        eDataTypes.String,//NR_CCG;
                        eDataTypes.DateTime,//DT_INI_VIG;
                        eDataTypes.DateTime,// DT_FIM_VIG;
                        eDataTypes.String,//TP_PROC
                        eDataTypes.String//ID_TRANS_CCG_REF
                    };
                }
                return _ccgDT;
            }
        }

        public static eDataTypes[] DataType_CCGPES
        {

            get
            {

                if (_ccgPesDT == null)
                {
                    _ccgPesDT = new eDataTypes[] {
                        eDataTypes.String,/*sistema_origem*/                 
                        eDataTypes.Number, // nr_emp
                        eDataTypes.String, // id_trans   
                        eDataTypes.String, // id_trans_ccg    
                        eDataTypes.String, // cd_funcao  
                        eDataTypes.String, // tpp
                        eDataTypes.String, //cp 
                        eDataTypes.String, // nome
                        eDataTypes.Number, // vl_limite_credito
                        eDataTypes.String, // op_ctrl_grupo_economico
                   };
                }
                return _ccgPesDT;

            }
        }

        public static eDataTypes[] DataType_CCGCOL
        {

            get
            {

                if (_ccgCOLDT == null)
                {
                    _ccgCOLDT = new eDataTypes[] {
                        eDataTypes.String, //#SISTEMA_ORIGEM
                        eDataTypes.Number, //NR_EMP
                        eDataTypes.String,//ID_TRANS
                        eDataTypes.String, //ID_TRANS_CCG
                        eDataTypes.String,//TP_COLATERAL
                        eDataTypes.String,//DESCRICAOTIPO
                        eDataTypes.Number,//VL_COLATERAL
                        eDataTypes.String,//PAIS
                        eDataTypes.String,//UF
                    };
                }
                return _ccgCOLDT;

            }
        }
        #endregion

        #region SNDOC
        public static eDataTypes[] DataType_SNDOC
        {

            get
            {

                if (_SNDOCDT == null)
                {
                    _SNDOCDT = new eDataTypes[] {
                       eDataTypes.String, //sistema_origem	
                        eDataTypes.Number,//nr_emp
                        eDataTypes.String,//id_trans
                        eDataTypes.String,//id_trans_sinistro
                        eDataTypes.String,//descr
                        eDataTypes.DateTime,//dt_acao	
                        eDataTypes.String//tp_acao
                   };
                }
                return _SNDOCDT;
            }
        }
        #endregion

        #region OBJSEG
        public static eDataTypes[] DataType_OBJSEG
        {

            get
            {

                if (_OBJSEGDT == null)
                {
                    _OBJSEGDT = new eDataTypes[] {
                         eDataTypes.String, //sistema_origem   
                         eDataTypes.Number,//nr_emp  
                        eDataTypes.String,//tp_operacao 
                        eDataTypes.String,//tp_info 
                        eDataTypes.String,//id_trans    
                        eDataTypes.String,//id_trans_objeto 
                        eDataTypes.String,//descr   
                        eDataTypes.String,//nr_registro 
                        eDataTypes.String,//tpp 
                        eDataTypes.String,//cp  
                        eDataTypes.String,//nome    
                        eDataTypes.String//tp_funcao_pessoa
                    };
                }
                return _OBJSEGDT;
            }
        }
        #endregion
    }
}
