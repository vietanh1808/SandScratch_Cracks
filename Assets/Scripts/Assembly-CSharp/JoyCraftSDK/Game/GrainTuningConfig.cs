using JoyCraftSDK.Utilities;
using UnityEngine;
using UnityEngine.Serialization;

namespace JoyCraftSDK.Game
{
	[CreateAssetMenu(fileName = "GrainTuningConfig", menuName = "GameSDK/GrainTuningConfig")]
	public class GrainTuningConfig : JScriptableObject
	{
		private const string G_Core = "Grain — Core";

		private const string G_Wall = "Grain — Wall";

		private const string G_FunnelSlide = "Grain — Funnel Slide";

		private const string G_BeltSide = "Grain — Belt Sideway";

		private const string G_BeltUp = "Grain — Belt Up";

		private const string G_BeltDown = "Grain — Belt Down";

		private const string G_Contact = "Grain — Contact";

		private const string G_Occ = "Grain — Occupancy + surface";

		private const string G_Gate = "Grain — Sliding Gate Wall";

		private const string G_Throttle = "Grain — Throttle";

		private const string G_BeltBoost = "Grain — Belt Boost + Max Gate";

		private const string G_BeltLevel = "Grain — Belt Level Multiplier";

		private const string Geo = "Rig Geometry";

		private const string Group_Convert = "Convert Pixel->Grain";

		private const string G_SwipeBatch = "Convert — Swipe Batch (TÚI)";

		private const string G_ColorBlast = "Booster — Color Blast (nổ vùng màu)";

		[Tooltip("Gia tốc trọng trường (world units/s^2, âm = xuống). Tune feel ở s5.")]
		[SerializeField]
		private float grainGravityY;

		[Tooltip("Bán kính hạt (world) — dùng cho pool + render (dia = 2×radius). Tune khớp cỡ Obi ở s5.")]
		[SerializeField]
		[Min(0.0001f)]
		private float grainParticleRadius;

		[Tooltip("Số bước tích phân con mỗi FixedUpdate (chống tunneling: hạt rơi nhanh xuyên tường mỏng). Chia dt/N rồi resolve N lần TRONG 1 job (vẫn 1 Complete/step). 1 = tắt. Nặng máy yếu -> hạ. Chọn N theo CFL: v_max·(dt/N) phải < ParticleRadius. Với gravity -150 + dt 0.02, hạt rơi tự do đạt ~100-150 world/s -> N=8 cho bước ~0.3 world; radius 0.12 -> vẫn hơi vượt, nhưng dải tường (edgeRadius+radius) dày hơn nên đỡ được. Tunneling còn -> nâng N trước khi động vào knob khác.")]
		[SerializeField]
		[Min(1f)]
		private int grainSubsteps;

		[Tooltip("Y (world) mà hạt rơi xuống dưới thì bị loại (pool bounded). Đặt DƯỚI đáy jar/màn.")]
		[SerializeField]
		private float grainDespawnY;

		[Tooltip("(FPS P1 chống death-spiral) TRẦN số solver-step chạy MỖI RENDER-FRAME. Frame dài -> Unity fixed accumulator bắn OnFixedUpdate nhiều lần catch-up (đo S8 emit: 5 call/frame = GrainComplete 5×O(N) = vòng xoáy tử thần). Cap = BỎ step vượt ngưỡng (grain SLOW-MO lúc tải nặng, KHÔNG dịch hạt sai — chỉ bỏ mô phỏng frame đó). Vật lý khác (dt) không đổi. 0 = TẮT (không cap = hành vi cũ bit-identical, để 0 khi ship tới khi đo chốt). ~2 = khớp cap đề xuất backlog (5->2 call).")]
		[SerializeField]
		[Min(0f)]
		private int grainMaxSolverStepsPerFrame;

		[Tooltip("0 = giữ fixed-step + cap (bit-identical). >0 = variable-timestep, 1 step/frame dt=min(deltaTime, giá trị này); tăng dần để bớt slow-mo, đổi lấy FPS. Trần hữu dụng ~= frame time thực.")]
		[SerializeField]
		[Min(0f)]
		private float grainMaxStepDt;

		[Tooltip("Nảy pháp tuyến khi chạm tường SDF (0 = cát không nảy). Mirror feel Obi restitution ~0.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainWallRestitution;

		[Tooltip("Ma sát tiếp tuyến tường: phần vận tốc TRƯỢT DỌC tường mất đi mỗi FRAME tiếp xúc liên tục (0 = trượt tự do, 1 = dính chết). Backend tự quy đổi theo Substeps (frictionKeep = pow(1-f, 1/substeps)) nên đổi Substeps gần như KHÔNG đổi ma sát cho hạt ÉP SÁT tường; hạt LƯỚT thì bù không đúng, còn lệch ~8× giữa substeps 1 và 8.\n⚠\ufe0f RÚT 2026-07-16: tooltip cũ ghi knob này gây 'hạt DÍNH mép khung thành hàng thẳng' và khuyên hạ về 0 để cô lập — SAI, đã đo bác: kéo 0.05 -> 0.7 (ép sát 5% -> 70%/frame) hàng KHÔNG đổi. Bám tường thành hàng đơn (Bug 6) KHÔNG đi qua ma sát; root = tường CỨNG trong vòng contact -> xem Grain Wall Compliance.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainWallFriction;

		[Tooltip("(Bug 6 · 2026-07-16) Độ NHƯỢNG của tường trong VÒNG CONTACT. 0 = tường cứng tuyệt đối = hành vi cũ nguyên si (nhánh bị skip, không sai số làm tròn) — ĐỂ 0 KHI SHIP cho tới khi play-test chốt.\nVÌ SAO có knob: contact hạt-hạt gỡ chồng lấn MỀM còn tường gỡ TRỌN VẸN mỗi iter => hạt sát tường không bao giờ mang được pen, mà pen là thứ DUY NHẤT sinh lực contact => không gì tán nó vào khối => mọi hạt chạm tường đọng trên ĐÚNG 1 mặt chiếu d=thr = 'hàng đơn' Bug 6. Nhượng ra -> hạt lún chút -> có pen -> bị khối hích tán như hạt thường.\n⚠\ufe0f Nới đúng hàng rào chống xuyên tường (chỉ vòng contact; integrate vẫn clamp CỨNG + CCD = thứ gánh Bug 2). Nâng knob PHẢI regression Bug 1-F2: ép đống dày sát khung -> không hạt nào lọt ra ngoài.\nThử: 0 -> 0.3 -> 0.6. Hàng vỡ ra ở mức nào, và mức nào bắt đầu rò tường.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainWallCompliance;

		[Tooltip("Bật/tắt funnel slide. TẮT = bỏ qua toàn bộ (như Speed = 0), giữ nguyên các số đã tune bên dưới.")]
		[SerializeField]
		private bool grainFunnelSlideEnabled;

		[Tooltip("Tốc độ trượt XUÔI dọc thành funnel/chute mục tiêu (world/s) cho hạt đang chạm tường. 0 = TẮT (hành vi cũ). Chỉ ĐẨY khi hạt chậm hơn, không phanh. Muốn trượt CHẬM hơn thì nâng grainWallFriction (áp mọi tường).")]
		[SerializeField]
		[Min(0f)]
		private float grainFunnelSlideSpeed;

		[Tooltip("Độ bám servo (1/s): mỗi giây kéo phần thiếu (Speed − tốc xuôi dốc) về 0 nhanh cỡ nào. Cao = đạt Speed gần tức thì.")]
		[SerializeField]
		[Min(0f)]
		private float grainFunnelSlideCoupling;

		[Tooltip("Ngưỡng ĐANG TRƯỢT (world/s): chỉ đẩy hạt có tốc xuôi dốc (đo đầu step, trước gravity) >= ngưỡng. Hạt đứng yên trong đụn nằm dưới ngưỡng -> KHÔNG bị kéo tuột -> đụn vẫn hình thành. 0 = đẩy mọi hạt chạm tường (đụn dễ sụp). Đụn vẫn tụt -> NÂNG; lớp sát tường không nhanh lên -> HẠ.")]
		[SerializeField]
		[Min(0f)]
		private float grainFunnelSlideMinSpeed;

		[Tooltip("(L5 far-field · 2026-08-06) BROAD-PHASE grid cho tường trong VÒNG CONTACT: thay vì quét TRỌN segmentCount (đo thật = 39) mỗi hạt mỗi iter, chỉ chạy các segment nằm trong ô grid của hạt.\nVÌ SAO: đo device S8 -> vế TƯỜNG chiếm 85-95% ms/apply-iter (7-10× vế occupancy) và mọi hạt đều trả phí quét dù chỉ 43-66% thật sự chạm. Skippable đo ở level thật ~85-92%.\nfalse = TẮT = đường quét-trọn cũ (rollback = 1 checkbox).\n⚠\ufe0f KHÁC bucket-grid neighbor (lever B): cái này BIT-IDENTICAL theo thiết kế — tập segment chạy là SIÊU TẬP của tập có thể clamp, giữ nguyên THỨ TỰ index, và có nhánh fallback quét-trọn khi hạt đi ra ngoài vùng phủ. Bật KHÔNG được đổi cảm giác cát; đổi = có bug, đừng tune bù.\n⚠\ufe0f Đọc lúc BuildSdfField (1 lần/level) -> đổi knob phải BUILD LẠI level mới ăn.")]
		[SerializeField]
		private bool grainWallGridEnabled;

		[Tooltip("(L5) Cạnh ô grid tường VÀ bán kính 'lang thang' A, tính theo bội của thr (= EdgeRadius + bán kính hạt, local). Build nhét mỗi segment vào mọi ô mà AABB của nó nở thêm (A + thr) phủ tới.\nNHỎ = ô mịn, ít segment/ô (nhanh hơn) NHƯNG A nhỏ -> hạt dịch quá A trong 1 lượt là rơi vào fallback quét-trọn (vẫn ĐÚNG, chỉ mất lợi ích). LỚN = an toàn hơn, mỗi ô ôm nhiều segment hơn.\nMốc: |delta| mỗi apply-iter đo được max 0.5×bán-kính-hạt ≈ 0.1×thr -> 2 là dư ~20×. Parity-gate đo hồi 2026-08-06 cho fallback = 0 ở giá trị này (probe đã gỡ sau khi cả 2 phase PASS).")]
		[SerializeField]
		[Range(0.5f, 8f)]
		private float grainWallGridCellMul;

		[Tooltip("(L5 phase 2 · 2026-08-06) Áp broad-phase tường cho VÒNG INTEGRATE (GrainIntegrateJob.ResolveContainment) — phase 1 chỉ gate vòng CONTACT. Vòng này quét trọn 39 segment MỖI SUBSTEP mỗi hạt.\n⚠\ufe0f ĐÒI GrainWallGridEnabled bật (grid dựng 1 lần/level ở BuildSdfField) và segmentCount <= 64.\nKHÁC query của vòng contact: ở đây bước đi tới ~4.4 bán kính/substep và ClampSegment chạy CCD trên TRỌN đoạn lpPrev->lp, nên vùng phủ là AABB CỦA ĐOẠN nở roam (không phải quả cầu quanh 1 điểm), và ứng viên gom bằng BITMASK để một segment nằm ở nhiều ô không bị clamp 2 lần.\nBIT-IDENTICAL theo thiết kế (kể cả velocity: ReflectVel giữ nguyên thứ tự) + có fallback quét-trọn. Bật KHÔNG được đổi cảm giác cát; đổi = có bug, TẮT knob chứ đừng tune bù.\nĐọc mỗi step (không phải lúc build) -> bật/tắt ăn ngay, KHÔNG cần build lại level.")]
		[SerializeField]
		private bool grainWallGridIntegrate;

		[Tooltip("BELT SPEED (servo): tốc độ TIẾP TUYẾN mục tiêu của băng chuyền (world/giây, CCW quanh spine stadium). KHÁC vortex cũ (accel hằng): belt kéo vận tốc tiếp tuyến của hạt VỀ tốc độ này → tốc độ ĐỀU khắp vòng, trọng lực được tự bù (leo cua thì thêm năng lượng, xuống cua thì phanh) → hết ứ đọng khúc lên / bị quăng khúc xuống. Cao = belt chạy nhanh. Tune cùng grainBeltCoupling (độ 'bám' belt).")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltSpeed;

		[Tooltip("BELT COUPLING (servo stiffness, 1/giây): độ MẠNH kéo hạt về grainBeltSpeed. Cao = hạt dính chặt tốc độ belt (đều, 'robotic'); thấp = lỏng, trọng lực + va chạm còn tạo biến thiên tự nhiên. Accel tiếp tuyến = coupling × (beltSpeed − tốc_độ_hiện_tại). ~20-40. 0 = tắt belt (hạt chỉ rơi tự do trong ring).")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltCoupling;

		[Tooltip("Bật clamp one-way: chặn hạt in-belt phọt ngược lên trên mép cửa entry (port ObiFlowEmitters BeltOneWay).")]
		[SerializeField]
		private bool grainBeltOneWay;

		[Tooltip("collision-fixes Bug5: hãm thành phần RADIAL của vận tốc hạt TRONG ring belt (1/giây), GIỮ NGUYÊN tiếp tuyến -> dập buzz mà KHÔNG làm chậm belt. Vortex chỉ cấp lực TIẾP TUYẾN, thiếu lực hướng tâm -> hạt bay thẳng, văng ra tường ngoài, bị snap về, vortex lại đẩy ra = BUZZ mỗi frame. Knob này đóng vai lực hướng tâm thiếu. ~8-15. Cột cửa entry đỉnh ring được MIỄN (ở đó radial trỏ lên = trọng lực; hãm sẽ chặn hạt rơi vào belt) nên nâng cao KHÔNG còn chặn cửa như bug 2026-07-15. Nhưng cao quá vẫn làm hạt trong ring khó lắng xuống đáy -> tăng dần, đừng nhảy cóc. 0 = tắt (hành vi trước khi có knob). Giá trị NỀN (áp đoạn thẳng + nửa xuống); nửa lên override bằng grainBeltUpRadialDamping.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltRadialDamping;

		[Tooltip("VÙNG THẢ ĐỈNH (0..1): belt 'thả' hạt dần khi lên cao trong rãnh trên của ring để trọng lực HẮT hạt rơi (projectile) như băng chuyền thật, thay vì servo tiếp tuyến lùa hạt NGANG qua crest (P1) + radial damping hãm luôn trọng lực ở đỉnh (P2). driveScale = 1 − release×t, t theo độ cao lp.y: đáy/cap/lúc leo cua = 0 (full drive, KHÔNG làm yếu cú leo cap + chảy vòng), lên tới vành ngoài (crest) = 1 (thả mạnh nhất). Nhân vào CẢ servo tiếp tuyến lẫn radial damping. Chưa rơi sớm / cát dốc qua đỉnh → TĂNG; khựng không qua được crest → GIẢM. 0 = TẮT (hành vi cũ y hệt, drive đồng nhất khắp vòng).")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainBeltTopRelease;

		[Tooltip("VÙNG THẢ — MỐC BẮT ĐẦU (0..1): hạ điểm bắt đầu 'thả' xuống thấp hơn để nhả SỚM hơn TRONG cú leo cap (không đợi tới sát crest). yStart = lerp(rIn, 0, giá_trị): 0 = bắt đầu ở rIn (mép trong rãnh, như cũ); 1 = bắt đầu ở spine y=0 (thả suốt nửa trên ring). 'Rơi xuống sau khúc cua lên chưa đủ sớm' → TĂNG.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainBeltTopReleaseStart;

		[Tooltip("VÙNG THẢ — HÃM TIẾP TUYẾN (1/giây, ≥0): bào dần tốc độ DỌC belt trong vùng thả (mạnh nhất ở crest) để hạt TRÚT phương NGANG và rơi THẲNG đứng. NGƯỢC grainBeltRadialDamping: radial triệt hướng-tâm → ép quỹ đạo CONG ôm tường; cái này triệt tiếp tuyến → chỉ còn trọng lực = rơi thẳng, KHÔNG cong. 'Cua xuống quá ngang' → TĂNG. ~5-15. 0 = tắt.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltTopTangentDamp;

		[Tooltip("(Belt BỘ LÊN) BELT SPEED nửa LÊN = TARGET LAUNCH (world/s): tốc độ tiếp tuyến mục tiêu ở nửa ĐANG GÁNH hạt leo (tanWorld.y>0). ĐỂ CAO hơn grainBeltSpeed (nửa xuống) -> hạt được servo kéo nhanh lên, tới crest bung ballistic DETERMINISTIC (target quyết vận tốc launch, không phụ thuộc overshoot). ×= belt-boost cuối màn như nửa xuống.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltUpSpeed;

		[Tooltip("(Belt BỘ LÊN) BELT COUPLING nửa LÊN (1/giây): độ mạnh kéo hạt về grainBeltUpSpeed ở nửa leo. ~40. Cao = bám chặt target launch (leo dứt khoát); thấp = lỏng, trọng lực còn ghì. Thay cách cũ ép launch bằng coupling=200 overshoot.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltUpCoupling;

		[Tooltip("(Belt BỘ LÊN) HÃM RADIAL nửa LÊN (1/giây): giữ hạt ép vào rãnh khi leo (khỏi văng ra tường ngoài). Mặc định = grainBeltRadialDamping (8). 0 = tắt.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltUpRadialDamping;

		[Tooltip("(Belt BỘ LÊN) VÙNG THẢ ĐỈNH nửa LÊN (0..1): thường ĐỂ 0 — nửa leo KHÔNG thả (đang cần lực nâng); release ở crest do bộ XUỐNG lo (blend chuyển sang nó khi qua đỉnh). >0 nếu muốn nhả sớm cả bên leo.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainBeltUpTopRelease;

		[Tooltip("(Belt BỘ LÊN) MỐC BẮT ĐẦU vùng thả nửa LÊN (0..1): chỉ dùng khi grainBeltUpTopRelease>0. Xem grainBeltTopReleaseStart.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainBeltUpTopReleaseStart;

		[Tooltip("(Belt BỘ LÊN) HÃM TIẾP TUYẾN vùng thả nửa LÊN (1/giây, ≥0): thường ĐỂ 0 (không bào tốc độ leo). Xem grainBeltTopTangentDamp.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltUpTopTangentDamp;

		[Tooltip("Hệ số nhân grainBeltSpeed khi vào conveyor-max (belt-full HOẶC swipe hết tranh). 1 = giữ nguyên. Đây là phần THAY THẾ maxConveyorSpeedRate cũ cho nửa XUỐNG/đoạn thẳng — số cũ trên prefab là 3.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltSpeedBoostRate;

		[Tooltip("Hệ số nhân grainBeltCoupling khi boost. Nâng CÙNG với SpeedBoostRate để hạt bám kịp target mới — chỉ nâng speed mà giữ coupling là công thức đẻ NÉN ở cua (deficit phình).")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltCouplingBoostRate;

		[Tooltip("Hệ số nhân grainBeltRadialDamping khi boost. Buzz radial đo được ~tuyến tính theo beltSpeed (2026-07-25) nên tốc cao có thể cần hãm radial mạnh hơn.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltRadialDampingBoostRate;

		[Tooltip("Hệ số nhân grainBeltUpSpeed (target LAUNCH nửa lên) khi boost. Số cũ trên prefab là 3. ⚠ servo 1-CHIỀU nên nửa XUỐNG hầu như không thấy boost — belt-boost chủ yếu đi qua ĐÂY (đo 2026-07-28).")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltUpSpeedBoostRate;

		[Tooltip("Hệ số nhân grainBeltUpCoupling khi boost.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltUpCouplingBoostRate;

		[Tooltip("Hệ số nhân grainBeltUpRadialDamping khi boost.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltUpRadialDampingBoostRate;

		[Tooltip("VÀO trạng thái belt-full (đóng cửa entry + boost belt + bắt đầu đếm giờ thua) khi FillRatio >= ngưỡng này. Phải > Exit để chống phập phù. Dời từ MaxGrainGate.maxConveyorSpeedEntry 2026-08-04 (prefab: 1).")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainBeltFullEntry;

		[Tooltip("RA khỏi belt-full (mở cửa + belt về nền + reset đồng hồ thua) khi FillRatio <= ngưỡng này. Phải < Entry. Dời từ MaxGrainGate.maxConveyorSpeedExit 2026-08-04 (prefab: 0.94).")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainBeltFullExit;

		[Tooltip("Giây kẹt LIÊN TỤC ở belt-full (fill chưa tụt dưới Exit) -> THUA (CheckLoseCondition, 1 lần mỗi đợt). Dời từ MaxGrainGate.beltFullTimeoutSeconds 2026-08-04 (prefab: 10).")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltFullTimeoutSeconds;

		[Tooltip("Giây kẹt LIÊN TỤC ở belt-full -> CẢNH BÁO SẮP THUA (raise OnPreLost, 1 lần mỗi đợt) trước khi thua thật ở Timeout. Phải < Timeout; >= Timeout thì cảnh báo không bao giờ kịp bắn. Cùng ĐỒNG HỒ với Timeout nên cũng bị PAUSE lúc booster đang chạy effect.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltFullPreLostSeconds;

		[Tooltip("Bật hệ số nhân belt theo level. TẮT = ×1 mọi level (hành vi cũ).")]
		[SerializeField]
		private bool grainBeltLevelMulEnabled;

		[Tooltip("Hệ số ở level <= Level Start.")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltLevelMulMin;

		[Tooltip("Hệ số ở level >= Level End (không tăng thêm sau level này).")]
		[SerializeField]
		[Min(0f)]
		private float grainBeltLevelMulMax;

		[Tooltip("Level bắt đầu tăng hệ số (tại level này hệ số = Min).")]
		[SerializeField]
		[Min(1f)]
		private int grainBeltLevelMulStart;

		[Tooltip("Level hệ số đạt Max. Phải > Level Start; <= Start thì mọi level >= Start nhận thẳng Max.")]
		[SerializeField]
		[Min(1f)]
		private int grainBeltLevelMulEnd;

		[Tooltip("s3 contact: số vòng Jacobi giải chồng lấn hạt-hạt mỗi step (port ý ParticleCollisionIterations Obi). Jacobi under-relax (softness>0) hội tụ CHẬM theo thiết kế -> BÙ bằng nhiều vòng, KHÔNG phải bằng cách nâng maxPush/hạ softness (2 cái đó phá ổn định). Đây là knob 'chặt hơn mà vẫn ổn định'. Tốn CPU tuyến tính.\n⚠ SỬA s5: khuyến nghị cũ '~6-10' QUÁ THẤP. Đo thật: 8 -> còn overlap rõ; 16 -> cát lún; 24 -> lún nhẹ; 30 -> hết overlap. Vì Jacobi lan 1 contact/vòng nên số vòng cần ≈ ĐỘ SÂU đụn tính theo hạt => ngưỡng ĐI THEO LEVEL, đụn cao hơn cần nhiều hơn. ĐỪNG tune sát ngưỡng của 1 màn (plan §1-L8).\nCHỐT SHIP (CTO 2026-07-16): ship = 48 vòng — chấp nhận overlap dư ở đây, KHÔNG đổi cấu trúc solver. Vòng thiết kế solver (E1 small-steps / E2 shock / E3 Gauss-Seidel) ĐÃ ĐÓNG: E1+E2 tự bác, E3 chỉ borderline, chi phí không rẻ hơn. Chi tiết: Docs/Game/Coding_plan/GrainFlow-Contact-Solver-Plan.txt §11.")]
		[SerializeField]
		[Range(1f, 96f)]
		private int grainContactIterations;

		[Tooltip("s3 contact: phần chồng lấn gỡ MỖI vòng Jacobi (0..1). Muốn chặt hơn -> tăng Iterations TRƯỚC.\n⚠ SỬA s5: tooltip cũ ghi '~0.5 là đủ; kéo lên 1 KHÔNG chặt hơn mà chỉ tăng biên độ sửa dư -> góp phần dao động' — SAI. Với Softness=1 (AVERAGE), relaxation thực tế ω = stiffness/N, nên stiffness=1 cho ω=1/N = ĐÚNG BẰNG biên ổn định mà chính §5-A4 đặt ra -> KHÔNG phân kỳ. Play-test s5: stiffness 1.0 + softness 1 + iterations 24 -> hết nhấp nháy. 1.0 là giá trị đang chạy.\nNhưng stiffness chỉ tăng tốc gỡ MỖI CẶP, KHÔNG rút ngắn quãng LAN TRUYỀN qua đụn (Jacobi lan 1 contact/vòng) -> hiệu quả kém xa Iterations khi đụn sâu. Rẻ hơn Iterations vì không tốn thêm vòng nào.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainContactStiffness;

		[Tooltip("s3 contact: RELAXATION Jacobi. 1 = AVERAGE theo contact-count (ω=1/N) = ỔN ĐỊNH, dùng cái này. 0 = SUM (ω=1): hạt ở đáy đống nhận TỔNG lực đẩy của cả N neighbor, mà N neighbor đó cũng đang tự đẩy ra cùng iteration -> mỗi cặp bị sửa dư ~N lần -> PHÂN KỲ = hạt NHẤP NHÁY tại chỗ vĩnh viễn. ⚠ settleDamping KHÔNG cứu được: contact dời VỊ TRÍ, settleDamping chỉ hãm VẬN TỐC. Trước đây tooltip ghi '0 = cứng nhất, dựa settleDamping chống jitter' — SAI, đã sửa 2026-07-15.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainContactSoftness;

		[Tooltip("(INTRUDER-BIAS 2026-08-04) CHIA correction chồng lấn theo AI ĐANG ĐỘNG, thay vì 50/50 cứng. 0 = TẮT = bit-identical (mỗi bên nửa pen như cũ); 1 = chia hẳn theo tỉ lệ tốc độ.\nTRIỆU CHỨNG NÓ CHỮA: cát rơi xuống TÁCH đụn ra 2 bên rồi CHEN vào giữa, thay vì trồng LÊN đụn.\nVÌ SAO: J3a đẩy nửa pen cho MỖI bên bất kể ai gây ra chồng lấn => hạt rơi đâm vào đụn thì đụn bị đẩy ra đúng bằng lượng hạt bị đẩy lên = ĐỤN NỞ SANG 2 BÊN. Với share theo tốc độ, hạt trong đụn (gần đứng yên) nhận ~0, hạt rơi nhận ~toàn bộ => nó bị đội NGƯỢC LÊN, đụn đứng yên.\nshare_i = 0.5 + bias×(|v_i|/(|v_i|+|v_j|) − 0.5), tổng 2 bên LUÔN = 1 (không bơm năng lượng, không phá đối xứng Jacobi). Dòng chảy đều (cả cụm cùng tốc) -> tỉ lệ = 0.5 -> KHÔNG đổi gì => belt/cột cát rơi chung không bị méo.\n⚠ KHÔNG đụng tới VẬN TỐC (khác knob maxFallSpeed đã BÁC+XÓA 2026-08-04 vì hạ tốc rơi thật). Đây thuần phân bổ VỊ TRÍ.\n⚠ Không chữa được ca hạt đã chôn SÂU 2+ đường kính (thiếu CCD hạt-hạt là chuyện riêng); nó chặn vế 'đụn bị banh ra', không chặn vế 'chui vào'. Bắt đầu A/B ở 1.0.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainContactIntruderBias;

		[Tooltip("s3 contact: CLAMP bước đẩy chồng lấn tối đa mỗi VÒNG (world). An toàn = giữ DƯỚI particleRadius: lớn hơn bán kính thì 1 vòng đơn lẻ dời hạt xa hơn chính nó -> khuếch đại dao động. ~0.4×radius. Chậm gỡ overlap -> tăng Iterations, ĐỪNG tăng cái này.\n⚠ SỬA s5: tooltip cũ ghi 'maxPush×Iterations phải NHỎ HƠN edgeRadius+radius' — LỖI THỜI từ s3. Ràng buộc TÍCH LUỸ đó chỉ đúng khi vòng contact không kiểm tường; nay GrainContactApplyJob gọi GrainSdfWalls.ClampWorld MỖI iter với pPrev = pos đầu iter (luôn wall-clean) -> không còn tích luỹ. Bound THẬT = per-iter (maxPush < edgeRadius+radius = 0.65 world), và ClampSegment có CCD nên không bound theo biên độ. Nhờ vậy s5 chạy được Iterations=30 (0.06×30 = 1.8, vượt xa 'luật' cũ mà không hề xuyên tường).\n⚠ Và maxPush KHÔNG phải cần gạt của overlap: softness=1 chia trung bình theo contact-count TRƯỚC khi clamp -> |d| trần = 0.5×stiffness×pen, trong đụn thật chỉ ~0.0125 = thấp hơn maxPush ~5×. Nó chỉ bind khi hạt chồng > 80% bán kính. Muốn hết overlap -> Iterations (xem plan §5-A5).")]
		[SerializeField]
		[Min(0f)]
		private float grainContactMaxPush;

		[Tooltip("s3 contact: hãm INELASTIC — GIẾT phần vận tốc hạt ĐÂM VÀO đống (0..1). 1 = cát NẶNG, KHÔNG bật lại; 0 = không hãm (nảy + chồng tái diễn). Đây là knob 'nặng/không bật': muốn nặng hơn -> tăng về 1.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainContactDamping;

		[Tooltip("(Fall-stutter 2026-07-27) TRẦN cho Damping ở trên, theo QUÃNG contact THỰC SỰ chặn được: kill <= mul × |corr|/dt. 0 = TẮT = hành vi cũ (bit-identical) — asset chưa có field cũng ra 0 nên mặc định KHÔNG đổi gì.\nVÌ SAO: Damping bản gốc giết 0.9×vn BẤT KỂ correction to hay bé — hạt đang RƠI chỉ SƯỢT nhau (corr ~0.005) cũng bị xoá 90% tốc độ rơi => KHỰNG giữa không trung. Contact chỉ hấp thụ được đúng |corr|/dt, cap lại là trả về đúng vật lý: hạt trong đống chịu áp lực (corr lớn) vẫn hãm FULL như cũ => overlap KHÔNG xấu đi.\n1 = đúng phần hấp thụ thật (điểm khởi đầu A/B). Nhỏ hơn 1 = hãm yếu hơn (rơi mượt hơn, coi chừng overlap); lớn hơn 1 = nới trần về phía hành vi cũ.\n⚠ ĐỪNG chữa khựng bằng cách hạ Damping: đã thử 0.1 => overlap bùng nổ, Iterations 32 + Softness 1 KHÔNG cứu nổi (play-test 2026-07-27). Damping còn là phép CHIẾU VẬN TỐC của PBD, bỏ nó thì velocity trôi khỏi thực tại, cả đống tích tốc độ rồi húc nhau.")]
		[SerializeField]
		[Min(0f)]
		private float grainContactAbsorbCapMul;

		[Tooltip("s3 contact: SETTLE — bleed vận tốc đẳng hướng mỗi step để tiêu tán dao động dư của hạt gần đứng yên. Đơn vị ~1/giây (Obi 'damping'). ~5 dập nhẹ. Cao quá -> cát chảy ì. 0 = tắt. ⚠ KHÔNG chữa được nhấp nháy do solver phân kỳ (softness=0): cái đó là dao động VỊ TRÍ, knob này chỉ đụng VẬN TỐC. Nhấp nháy tại chỗ -> sửa Softness, không phải knob này. (Tooltip cũ ghi 'hết jitter nảy liên tục' — SAI, đã sửa 2026-07-15.)")]
		[SerializeField]
		[Min(0f)]
		private float grainContactSettleDamping;

		[Tooltip("(GRAINFRICTION s4 2026-07-27) MA SÁT Coulomb hạt-hạt PER-PAIR, tầng VẬN TỐC (J4): mỗi cặp chồng lấn tại posPredicted -> trượt tiếp tuyến TƯƠNG ĐỐI vt_rel (velSnap[i]-velSnap[j]) bị trừ mỗi bên min(½|vt_rel|, μᵥ×pen/dt) — tải per-CONTACT = pen đo SAU gravity TRƯỚC solver, ∝ áp lực cột. μᵥ ≈ TAN GÓC NGHỈ của đụn (0.6 ~ 31° · 1 ~ 45° · >1 hợp lệ cho dốc hơn). Trượt nhỏ hơn trần -> triệt HẲN = ma sát TĨNH (đụn khoá hình); vượt -> hãm bớt = ma sát ĐỘNG (avalanche vẫn chảy). Dòng chảy đều cả cụm cùng v => relV≈0 => KHÔNG hãm. 0 = TẮT = bit-identical. Chi phí: +1 copy job + 1 lượt query 3×3/step hạt thức.\n3 LỚP video ref TỰ SINH, không classifier: hạt-tường/tranh KHÔNG phải cặp hạt-hạt => layer sát mặt trượt tự do · đỉnh đụn ít contact + pen bé => avalanche · lõi cột pen lớn => khoá.\n⚠ μᵥ cao gây ARCHING (cát bắc VÒM qua khe, mở gateWall KHÔNG chảy) — granular thật, test drain cửa MỞ là điều kiện pass số 1.\n⚠ Vì sao PER-PAIR mà không phải proxy per-hạt (3 bản đã play-test bác 2026-07-27): dvn cần vn<0 — hạt TĨNH vn≈0 => trần≈0, không có ma sát tĩnh; pen residual ≈0 ở mặt thoáng => μ rơi khỏi công thức; corrN (s3) cộng VECTOR — hạt lõi bị ép từ nhiều phía đối nhau, dN tự khử => trần không scale tải (chữ ký: μᵥ gấp 3 mà hành vi y nguyên) + kẹp v TUYỆT ĐỐI => phanh cả dòng chảy đều. Coulomb đòi Σ|Fₙ| TỪNG contact + trượt TƯƠNG ĐỐI — chỉ per-pair cho cả hai.")]
		[SerializeField]
		[Range(0f, 8f)]
		private float grainFrictionVelocity;

		[Tooltip("(SURFACE-DRAG 2026-08-04) TỐC ĐỘ LỞ của lớp mặt đụn — hãm thêm `drag × |v trượt tương đối|` mỗi cặp hạt CHỒNG LẤN, ĐỘC LẬP pen. 0.15-0.3 = vùng dò; >=0.5 = triệt hẳn trượt tương đối. 0 = TẮT = bit-identical.\nVÌ SAO CẦN KNOB RIÊNG: cap Coulomb của grainFrictionVelocity là μᵥ×pen/dt, mà hạt ở MẶT THOÁNG không chịu tải => pen≈0 => cap≈0 => lớp đang LỞ nằm NGOÀI TẦM VỚI của μᵥ, vặn bao nhiêu cũng vậy (chữ ký đo được 2026-08-04: μᵥ 2->8 đụn khoá chắc hơn mà tốc lở y nguyên). Đây là số hạng duy nhất chạm được lớp đó.\n⚠ KHÔNG đụng hệ khác nhờ 4 lớp cách ly: (1) chỉ chạy khi có CẶP hạt chồng lấn thật => hạt rơi trong không khí miễn nhiễm · (2) đo vận tốc TƯƠNG ĐỐI => dòng chảy đều (belt, cột cát rơi cùng nhau) relV≈0 => early-out, KHÔNG phanh belt/cú rơi (khác bản kẹp v TUYỆT ĐỐI đã bác s3) · (3) hạt-tường và hạt-tranh KHÔNG phải cặp hạt-hạt => grainOccupancySlip/wallFriction nguyên vẹn · (4) 0 = min() rút về biểu thức cũ.\n⚠ ĐÁNH ĐỔI đã lường: chùm cát rơi lúc XOÈ RA cũng có relV≠0 nên sẽ 'dính' hơn chút ở chỗ tiếp đất. Nếu khó chịu thì bước 2 = gate cnt>=2 (hạt sượt khi rơi có 1 contact, hạt nằm trên mặt đụn có >=2), CHƯA ship.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainFrictionSurfaceDrag;

		[Tooltip("(GRAINFRICTION hướng A 2026-07-28) MA SÁT Coulomb hạt-hạt PER-PAIR, tầng VỊ TRÍ + GHI NGƯỢC v: mỗi cặp chồng lấn tại posPredicted -> đo DỊCH CHUYỂN tiếp tuyến tương đối THỰC TẾ frame này (positions-posPrev, bắt được creep g·dt²·sinθ ở tầng vị trí mà mọi friction VẬN TỐC mù — root 5 biến thể chết) -> kéo lùi p min(share·|Δt|, μₚ×pen) VÀ v += Δp/dt (chỉ phần friction, pháp tuyến không đụng — thiếu vế ghi-ngược = dây chun s1/s2). μₚ ≈ TAN GÓC NGHỈ. Dòng chảy đều Δ_rel≈0 => không phanh; hạt rơi sượt pen bé => cap bé => không khựng. 0 = TẮT = bit-identical (2 job mới không schedule, J4 không deref).\n⚠ μₚ cao gây ARCHING (vòm qua khe) — test drain cửa MỞ là điều kiện pass số 1.")]
		[SerializeField]
		[Range(0f, 2f)]
		private float grainFrictionPosMu;

		[Tooltip("(GRAIN-GRAIN CCD 2026-08-05) CONTINUOUS collision hạt-hạt (J2.5, POSITION-ONLY): quét đoạn posPrev(đầu step)->positions(sau integrate), KẸP hạt bay nhanh về điểm chạm hạt đầu tiên.\nTRIỆU CHỨNG NÓ CHỮA: hạt rơi nhanh XUYÊN qua lớp mặt của đụn, hạ cánh vào GIỮA đụn (bước v·dt vượt trọn 1 hạt; J3a test 1 ĐIỂM ở pos sau integrate nên mù). Tường/tranh có sweep pPrev->p, hạt-hạt thì không -> đây bù đúng vế đó.\nĐƠN VỊ = BÁN KÍNH, gate NGƯỠNG VẬN TỐC TƯƠNG ĐỐI: CHỈ kẹp khi |v_i − v_j|·dt > gate·radius. Vì sao gate theo TƯƠNG ĐỐI (không tuyệt đối): cột cát rơi là đám hạt CHẠM NHAU cùng tốc -> nếu gate tuyệt đối thì chúng bị kẹp về start mỗi step = 'rơi cực chậm' (bug play-test #1/#2). Gate tương đối -> cột co-moving |rel|≈0 BỎ QUA = giữ tốc rơi; chỉ faller đâm mặt đụn TĨNH (|rel| lớn) mới bị kẹp.\nDò: THẤP quá -> cột cát chậm lại (over-clamp co-moving); CAO quá -> hạt vẫn chui vào giữa đụn (under). Bắt đầu ~1.0, nới lên nếu còn chậm, hạ xuống nếu còn chui.\n⚠ KHÔNG đụng VẬN TỐC: v CHỈ để QUYẾT vị trí kẹp (position-only); hãm rơi ra TỰ NHIÊN ở J4 (|corr| to -> absorbCap hết bó -> dừng inelastic tại mặt). Sửa TIỀN ĐỀ chứ không nới trần.\n0 = TẮT = bit-identical (backend KHÔNG schedule job J2.5).")]
		[SerializeField]
		[Min(0f)]
		private float grainGrainCcdGate;

		[Tooltip("(CCD J2.5 play-test #4 2026-08-06) TRẦN quãng CCD được GIẬT LÙI hạt, đơn vị BÁN KÍNH. 0 = KHÔNG kẹp = lùi trọn về điểm chạm (hành vi 2026-08-05).\nTRIỆU CHỨNG NÓ CHỮA: 'hạt BẬT NẢY khi va vào đụn'. Cơ chế: CCD lùi hạt i về điểm chạm, nhưng hạt THEO SAU trong cột KHÔNG biết (CCD đọc posPrev[j]+velocities[j], mà v của i vẫn nguyên tốc -> cặp đó co-moving -> không kẹp) => i lùi LÊN ĐÂM vào hạt trên nó => bơm overlap ~ đúng quãng lùi (hạt rơi nhanh: |d| = v·dt ≈ 3 bán kính) => J3 gỡ overlap đó = đội hạt trên NGƯỢC LÊN = cái 'nảy'.\n⚠ ĐỪNG chữa bằng grainContactMaxPush: nó kẹp TỐC ĐỘ đẩy/frame, KHÔNG kẹp QUÃNG đẩy tổng — tổng quãng đội ngược = lượng overlap bơm vào, nên hạ maxPush chỉ TRẢI cùng biên độ ra nhiều frame (PLAY-TEST 2026-08-06: 0.06 -> 0.015 nảy Y NGUYÊN). Biên độ nảy = QUÃNG LÙI => chỉ knob này cắt được.\n⚠ Cũng ĐỪNG chữa bằng damping/settleDamping/absorbCapMul: J4 làm 'v += damping·kill·cn' = CHỈ GIẢM vận tốc pháp tuyến, toán học không thể đảo chiều v (damping 0.9 < 1, không có vế rebound). Nảy là chuyển động VỊ TRÍ do J3 đẩy, không phải vận tốc.\nĐÁNH ĐỔI: hạt dừng LÚN vào mặt đụn phần dư (quãng lùi − trần), J3 gỡ nốt — đúng hành vi trước CCD nhưng chỉ còn phần DƯ nhỏ thay vì trọn cú tunnel.\nDò: 1.0 -> 0.5, lấy giá trị NHỎ NHẤT mà hạt vẫn chưa chui vào GIỮA đụn. NHỎ quá -> tái phát chui giữa đụn; LỚN quá (hoặc 0) -> nảy.\nTIÊU CHÍ BÁC (chốt trước play-test): 0.5 mà biên độ nảy KHÔNG giảm rõ => mô hình 'nảy = quãng lùi' SAI => DROP CCD (grainGrainCcdGate = 0), đừng đắp thêm knob nữa.")]
		[SerializeField]
		[Min(0f)]
		private float grainGrainCcdMaxPull;

		[Tooltip("(FPS lever B, bản ROW-MAJOR 2026-08-06) ĐỔI CONTAINER neighbor-search: NativeParallelMultiHashMap -> LƯỚI ROW-MAJOR. Query 3×3 = 3 DẢI LIÊN TỤC (1 dải/hàng) thay 9 probe băm ngẫu nhiên; 0 hash, 0 nhánh lọc khoá. Phục vụ CẢ 5 consumer: contact J3a (×Iterations), CCD J2.5, friction vị trí, friction vận tốc (J4 ApplyPairFriction).\nfalse = TẮT = đường hashmap cũ BIT-IDENTICAL (rollback = 1 checkbox).\n⚠ BẬT KHÔNG bit-identical, 2 lý do: (1) thứ tự duyệt đổi -> thứ tự cộng float đổi; (2) đường hashmap ĐẾM ĐÔI khi 2 trong 9 ô đụng math.hash, lưới thì không -> tập ứng viên của lưới mới là ĐÚNG theo định nghĩa. Verify bằng TẬP ứng viên (GrainFlowBackend.NeighborDiag — chân lý brute-force), KHÔNG bằng so bit. Đổi cảm giác cát = phải play-test lại.\n⚠ Bản BUCKET-GRID băm (2026-07-27) đã XOÁ, không phải đổi tên: nó vẫn là hash-table.")]
		[SerializeField]
		private bool grainNeighborGridEnabled;

		[Tooltip("(FPS lever C′ 2026-08-06) ĐỘ MỊN của lưới neighbor: cạnh ô = 2r/m, quét ±m dải (thay 1 ô 2r ±1 dải). Tập CONTACT không đổi (test khoảng cách y nguyên) — chỉ BỚT ứng viên phải test: diện tích quét 4r²(2+1/m)² = 36r² (m=1) -> 25r² (m=2, −31%) -> 22r² (m=3, −38%). Ăn vào MỌI iter của J3a + CCD + 2 friction.\n1 = lưới như cũ (mốc A/B, rollback). Chỉ có tác dụng khi grainNeighborGridEnabled = true.\n⚠ KHÔNG bit-identical khi đổi (thứ tự duyệt đổi -> thứ tự cộng float đổi) — verify bằng TẬP ứng viên (NeighborDiag: chân lý brute-force TỰ theo cell/ring đang chạy), rồi mới đo FPS.\n⚠ m to = lưới nhiều ô hơn: AABP chạm trần MaxDim 512 thì hạt xa bị kẹp về ô biên (an toàn, chỉ thừa ứng viên). m>4 bị kẹp về 4.")]
		[SerializeField]
		[Range(1f, 4f)]
		private int grainNeighborGridSubdiv;

		[Tooltip("(FPS lever 2b — PACKING 2026-08-07) Gom 3 thứ mà contact J3a phải NHẢY NGẪU NHIÊN đi lấy cho từng ứng viên (vị trí · tốc độ của hạt j) thành MỘT DÃY LIÊN TỤC dựng lại trước mỗi vòng lặp: mỗi ứng viên còn 1 lần đọc tuần tự thay 3 lần nhảy.\nfalse = TẮT = đường cũ, KHÔNG đụng mảng packed.\n✅ BẬT là BIT-IDENTICAL (dãy chép nguyên si số cũ, không đổi phép toán nào) — verify bằng SO BIT, khác hẳn lever lưới/subdiv ở trên (2 cái đó đổi thứ tự duyệt nên chỉ verify được bằng TẬP ứng viên). Cảm giác cát KHÔNG đổi -> không cần play-test lại, chỉ cần đo FPS.\n⚠ Chỉ có tác dụng khi grainNeighborGridEnabled = true (cần con trỏ entry của lưới).\n⚠ Đổi lại: tốn 1 pass dựng dãy mỗi vòng lặp (J3repack trong log StageDiag). TRẦN lý thuyết đo được trên device là 57.3% của J3a; 2b chỉ ăn một phần vì vẫn phải đọc entryIdx + tốn pass này. Lời hay lỗ phải ĐO TRÊN MÁY THẬT (StageDiag.AbPacked), số Editor từng ngược dấu device ở lever C′.")]
		[SerializeField]
		private bool grainNeighborPackEnabled;

		[Tooltip("(FPS lever 2b-SPLIT 2026-08-07) Chỉ có tác dụng khi bật knob packing ở trên. Tách dãy liên tục làm ĐÔI theo nhịp đổi của dữ liệu: VỊ TRÍ dựng lại mỗi vòng lặp (nó đổi mỗi vòng), còn TỐC ĐỘ dựng ĐÚNG 1 LẦN mỗi bước (chúng không đổi trong lúc giải va chạm).\n⚠ VẪN BIT-IDENTICAL: y hệt số, chỉ khác chỗ cất -> cảm giác cát không đổi.\n⚠ Lý do có knob này: bản gộp chỉ ăn ~¼ trần đo được, nghi chính pass dựng dãy làm nguội cache. Tách đôi cắt ~½ byte phải chạm mỗi vòng. Lời hay lỗ ĐO TRÊN MÁY THẬT (StageDiag.AbPacked lật 3 bên 0/1/2).")]
		[SerializeField]
		private bool grainNeighborPackSplit;

		[Tooltip("s3 occupancy: vận tốc đẩy hạt ra khỏi pixel tranh CHƯA tan (world/s). Bị KẸP bởi occupancyMaxStep nên không tự launch; cao = ra nhanh. 0 = tắt va chạm tranh (hạt rơi xuyên vùng tranh).")]
		[SerializeField]
		[Min(0f)]
		private float grainOccupancyPushStrength;

		[Tooltip("s3 occupancy: CLAMP dịch chuyển đẩy mỗi call (world) — chống hạt VỌT lên quá mặt tranh = NẢY liên tục (bug launcher). Nhỏ (~0.015) = hạt chỉ chạm mặt rồi DỪNG, không bật. Quá nhỏ -> hạt rơi nhanh lún vào tranh.")]
		[SerializeField]
		[Min(0f)]
		private float grainOccupancyMaxStep;

		[Tooltip("s3 occupancy SURFACE-SLIDE: khi hạt chạm mặt tranh, chuyển phần momentum bị chặn sang HƯỚNG DỐC của mặt (normal làm mịn, bán kính = OccupancySmoothRadius) -> hạt TRƯỢT dọc contour & rơi khỏi đáy thay vì kẹt thành LỚP MỎNG bám mép răng-cưa. 0 = tắt (bám như cũ); ~0.6 = trượt mượt; 1 = trơn hẳn. Mặt macro PHẲNG NGANG vẫn giữ cát (đúng angle-of-repose). Slip đã kịch mà vẫn bám -> nâng SmoothRadius.")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainOccupancySlip;

		[Tooltip("collision-fixes Bug4: bán kính cửa sổ (đơn vị occ-cell) gộp normal MACRO của mặt tranh cho surface-slide. Là ĐÒN BẨY CHÍNH của 'hạt kẹt dính mép tranh' — slip chỉ quyết định trượt MẠNH bao nhiêu, còn knob này quyết định có NHÌN RA độ dốc để mà trượt hay không. Nhỏ (2 = cửa sổ 5×5, giá trị hardcode cũ) -> normal vẫn bám răng-cưa micro -> mặt dốc bị hiểu nhầm là phẳng -> gTan≈0 -> hạt đọng. ~4 thấy được dốc macro. Cao quá -> mép cong bị làm phẳng, cát trượt cả ở chỗ đáng lẽ đọng. Chi phí (2r+1)² ô/lần chạm.")]
		[SerializeField]
		[Range(1f, 6f)]
		private int grainOccupancySmoothRadius;

		[Tooltip("(LEAK fix B) DILATE occupancy: phình snapshot tranh N ô Chebyshev mỗi step (Burst job, trước J0) để bù BÁN KÍNH hạt mà SweepBlocked bỏ qua (DDA quét ĐIỂM tâm; r/occCell đo hub 2026-07-29 = 1.171 -> thân hạt lách qua ô mép = radius-leak 3-5 hạt xuyên tranh). 0 = TẮT = bit-identical (không job, không copy thêm). 1 = phủ 1.0/1.17 r (đủ — DDA còn dừng epsilon trước mặt). Trade-off ĐÃ CHẤP NHẬN (council 07-28): tranh 'dày' thêm N ô -> hạt đọng mép (bug C) nặng hơn -> tune creep ở P4; hạt emit sát pixel Solid có thể born-inside vành dilate -> gradient-eject lo. CreepDownhill tự nới lateralMax/creepWindow theo N.")]
		[SerializeField]
		[Range(0f, 2f)]
		private int grainOccupancyDilateCells;

		[Tooltip("(R2 B′ 'hạt đọng lỳ mép tranh') POSITION-creep vận tốc (world/s): hạt TỰA mép tranh nhích VỊ TRÍ tới ô-trống-xuôi-nhất để rời sườn dốc thay vì đọng lỳ. KÊNH RIÊNG — bypass cap eject + settleDamping (KHÔNG đụng v) vì cap kẹp |v| về |v|-VÀO mỗi va chạm nên drive-trượt qua kênh vận tốc không tích luỹ. 0 = TẮT (hành vi cũ NGUYÊN SI). ~1.0 để bắt đầu tune. Chạy per-substep, kẹp bởi OccupancyMaxStep. CHỈ tác động monolayer CHẠM tranh (hạt xếp trên hạt không đủ gần) -> không hoá-lỏng pile.")]
		[SerializeField]
		[Min(0f)]
		private float grainSurfaceCreepSpeed;

		[Tooltip("(R2 B′) Ngưỡng 'xuôi': dot(hướng-tới-ô-trống, hướng-trọng-lực) tối thiểu để creep. ~0.3 (ô trống phải chếch xuống ≥ ~72° so phương ngang). Mặt phẳng -> ô trống chỉ ngang/lên -> dưới ngưỡng -> KHÔNG creep (giữ angle-of-repose). Cao -> chỉ shed dốc gắt; thấp -> shed cả dốc thoải (rủi ro hoá-lỏng).")]
		[SerializeField]
		[Range(0f, 1f)]
		private float grainSurfaceCreepSlopeMin;

		[Tooltip("(R2 B′) Bán kính cửa sổ (occ-cell) quét ô-trống-xuôi-nhất. 2 = 5×5. Lớn -> 'nhìn' xa hơn qua micro-ledge (shed off-ledge tốt hơn) nhưng tốn (2w+1)² ô/hạt. 2-3 hợp lý.")]
		[SerializeField]
		[Range(1f, 4f)]
		private int grainSurfaceCreepWindow;

		[Tooltip("(R2 (b) creep-off-edge) Tầm quét MÉP RƠI hai bên khi hạt tựa mặt tranh, tính bằng ô tranh THẬT (code tự cộng thêm DilateCells). Cả 2 mép xa hơn tầm này = coi là 'lòng phẳng/thung lũng' -> hạt NGHỈ. Trước 2026-07-30 là hằng 4 trong code. Nâng -> hạt chịu đi xa hơn để tìm mép rơi (đọng ít hơn, tốn quét hơn); hạ -> nghỉ sớm. 0 = dùng lại hằng cũ 4.")]
		[SerializeField]
		[Range(0f, 16f)]
		private int grainCreepLateralMax;

		[Tooltip("(EJECT hướng) Khi tâm hạt lọt SÂU vào khối tranh đặc, gradient occupancy suy biến (4 hàng xóm đều đặc) -> bản cũ đẩy cứng 'về ĐỈNH tranh' nên hạt bò hết chiều cao tranh rồi đậu trên nóc (play-test 2026-07-30). Số này = bán kính quét ô TRỐNG gần nhất để lấy hướng đẩy thay thế (occ-cell). 0 = TẮT = hành vi cũ (bit-identical). ~6 phủ quá thân hạt (2.34 ô) + kênh vừa cào. Chỉ chạy ở nhánh suy biến (bệnh lý, hiếm) nên không phải đường nóng.")]
		[SerializeField]
		[Range(0f, 12f)]
		private int grainOccupancyEjectSearchCells;

		[Tooltip("SCROLL (ScrollPicture): tốc độ tranh TỤT XUỐNG khi cào thủng đáy cột — đơn vị HÀNG PIXEL MECHANIC/giây (không phải world/s, không phải hàng view-res). Mỗi cột tween độc lập tới đáy khối tranh của nó. 10 = điểm khởi đầu để tune, CHƯA đo. Cao -> tụt gấp, dải chặn swipe ở đỉnh khó theo kịp hàng mới lộ; thấp -> chờ lâu sau mỗi nhát cào. Sống ở ĐÂY (feel) chứ không ở PixelLevelData (data của ẢNH).")]
		[SerializeField]
		[Min(0f)]
		private float grainScrollRowsPerSecond;

		[Tooltip("SCROLL (gate g3): SỐ HẠT còn được phép nằm trong cửa sổ cột mà VẪN cho tranh tụt. 0 = luật cũ (phải SẠCH TUYỆT ĐỐI mới tụt). x > 0 -> chỉ cần còn dưới x hạt là tụt — cột đỡ đứng lâu vì vài hạt lẻ kẹt trên gờ tranh, ĐỔI LẠI mấy hạt đó bị tranh 'mọc' dưới chân (P8) nên có thể bị đẩy/kẹt vào thân tranh. Nâng từ từ, play-test lại vế hạt xuyên tranh.")]
		[SerializeField]
		[Min(0f)]
		private int grainScrollClearGrainMax;

		[Tooltip("Cửa trượt gateWall — giới hạn DƯỚI (y min) của slider dịch cửa (offset so mặc định y=rOut). Đơn vị geometry-local (rOut~0.3). Nới ÂM thêm nếu cần kéo cửa xuống xa hơn.")]
		[SerializeField]
		private float grainGateWallYMin;

		[Tooltip("Cửa trượt gateWall — giới hạn TRÊN (y max) của slider dịch cửa. Đơn vị geometry-local.")]
		[SerializeField]
		private float grainGateWallYMax;

		[Tooltip("DỊCH y CỬA TRƯỢT gateWall (kéo LÊN/XUỐNG) so mặc định (đỉnh ring y=rOut). + = LÊN, - = XUỐNG. Slider giới hạn bởi grainGateWallYMin..Max. Đơn vị geometry-local (TRƯỚC geomScale). Đọc LIVE mỗi frame (khỏi rebuild); bật drawSdfGizmos trên GrainFlowBackend để thấy vạch cửa (đỏ) mà canh.")]
		[SerializeField]
		private float grainGateWallYOffset;

		[Tooltip("ĐỘ DÀY cửa trượt gateWall = hệ số nhân độ dày tường chung (Thr = EdgeRadius+GrainParticleRadius). 1 = y hệt tường khác; >1 = cửa DÀY hơn (chặn chắc hơn) mà KHÔNG đụng collider/tường nào khác; <1 = mỏng hơn. Áp RIÊNG cho cửa qua GrainSdfField.doorThr (LIVE mỗi frame, khỏi rebuild).")]
		[SerializeField]
		[Min(0.1f)]
		private float grainGateWallThicknessMul;

		[Tooltip("TỐC ĐỘ TRƯỢT cửa gateWall khi đóng/mở, đơn vị ĐỘ-ĐÓNG/GIÂY (openness 0..1 -> 2 = đi hết hành trình trong 0.5s, 1 = 1s). 0 -> 1 độ-đóng/giây. Đọc LIVE mỗi frame (GrainFlowBackend MoveTowards).\n⚠ 2026-08-04: fallback cũ 'để 0 = dùng MaxGrainGate.maxConveyorSpeedRate' ĐÃ GỠ (field đó xoá khi tách belt-boost thành 6 rate per-knob). Tốc cửa nay CHỈ đọc knob này.")]
		[SerializeField]
		[Min(0f)]
		private float grainGateWallSpeed;

		[Tooltip("(BOOSTER THỔI CÁT) Nới TRẦN vùng hút của blower LÊN TRÊN đỉnh ring (y=rOut), tính theo BÁN KÍNH HẠT, chỉ trong dấu chân miệng phễu (|x|<=FunnelMouthHalfWidth). Hạt bị belt đẩy văng qua crest nằm hờ trên y=rOut vài step -> IsInBeltLocal (box chặt) bỏ sót -> blower hút không hết (bug LV12 2026-09-17). 0 = TẮT = bit-identical. Gợi ý ~3. CHỈ áp cho BlowerPass — KHÔNG đổi RecomputeRegionCount/FillRatio/MaxGrainGate/box-swap count.")]
		[SerializeField]
		[Min(0f)]
		private float grainBlowerCaptureMarginRadii;

		[Tooltip("SỐ HẠT sống toàn màn để CHẶN SWIPE (throttle input — mục tiêu UX, chống user cào thêm khi hạt đã dày). Live-count >= ngưỡng -> SandSwipeController chặn cào tới khi tụt <= GrainThrottleExit (hysteresis). Level nặng CHỦ ĐÍCH -> để CAO (~5000). Swipe đọc LIVE mỗi frame. ⚠ KHÔNG còn xác định trần pool (tách sang grainsPerPixelDivisor 2026-07-28) và KHÔNG hạ peak N/40ms pour — chỉ gate input.")]
		[SerializeField]
		[Min(1f)]
		private int grainThrottleEntry;

		[Tooltip("SỐ HẠT sống để BỎ CHẶN swipe (cho cào lại). Nên < GrainThrottleEntry (hysteresis chống bật/tắt swipe phập phù quanh ngưỡng).")]
		[SerializeField]
		[Min(1f)]
		private int grainThrottleExit;

		[Tooltip("SỐ PIXEL solid TRUNG BÌNH mỗi hạt grain — chia số pixel solid của level ra TRẦN pool (capacity = ceil(solidPixels / divisor); GrainFlowBackend.ResolveCapacity đọc lúc Build, per-level). THAY cơ chế cũ 'GrainThrottleEntry + 512' (2026-07-28): pool ôm TRỌN max-grain level -> AcceptSand không bao giờ rớt hạt = BỎ throttle convert. Thấp hơn = pool TO hơn (đệm khi grouping thực gom < divisor pixel/hạt); cao hơn = pool nhỏ, RỦI RO rớt hạt nếu grain thật > solid/divisor. 1.5 = group trung bình mặc định.")]
		[SerializeField]
		[Min(0.1f)]
		private float grainsPerPixelDivisor;

		[Tooltip("Số điểm rasterize mỗi nửa cung stadium (cao = mượt + ít tunnelling ở cua, tốn hơn).")]
		[SerializeField]
		[Range(4f, 128f)]
		private int capSegments;

		[Tooltip("Bề dày EdgeCollider2D (world). LEVER R1: dày hơn -> khó xuyên tường 1-cell (bù substeps thấp), nhưng ăn vào lòng rãnh. S8 granular chốt ~0.03.")]
		[SerializeField]
		[Min(0f)]
		private float edgeRadius;

		[Tooltip("Bề rộng ô hở ĐỈNH vành ngoài (world) — cửa cát rơi từ chute vào rãnh belt. ~channelWidth. CŨNG LÀ bề rộng ĐẦU RA chute (đáy chute khớp đúng ô hở này); đầu VÀO chute = chuteInputWidth.")]
		[SerializeField]
		[Min(0.01f)]
		private float entryGapWidth;

		[Tooltip("ĐỘ CAO (world) của 2 CẠNH CHÉO (funnel) — phần khung tranh thu hẹp từ miệng phễu (±funnelMouthHalfWidth) xuống đầu VÀO chute (±chuteInputWidth/2). Cạnh chéo NẰM NGAY TRÊN chute (chute mới nối tiếp xuống conveyor). Config trực tiếp — KHÔNG còn bị góc phễu override (funnelWallAngleDeg đã gỡ 2026-07-13).")]
		[SerializeField]
		[Min(0.1f)]
		private float funnelHeight;

		[Tooltip("Nửa bề rộng MIỆNG phễu = nửa bề ngang tường khung (LOCAL, ×RigGeometryScale ra world). Phễu thu về chuteInputWidth ở đáy cạnh chéo. Obi mode: knob CHÍNH cỡ khung (KHÔNG auto-fit theo tranh — user tự căn tranh khớp bằng quad pose).")]
		[SerializeField]
		[Min(0.1f)]
		private float funnelMouthHalfWidth;

		[Tooltip("ĐỘ DÀI chute (world) — đoạn nối THẲNG/thuôn từ đáy 2 cạnh chéo xuống ô entry conveyor. 0 = TẮT chute (cạnh chéo nối thẳng xuống conveyor như cũ). >0 = chèn chute cao chuteLength giữa cạnh chéo và conveyor.")]
		[SerializeField]
		[Min(0f)]
		private float chuteLength;

		[Tooltip("Bề rộng ĐẦU VÀO chute (world) = miệng TRÊN chute, nơi 2 cạnh chéo đổ vào. Đầu RA chute (đáy, tại conveyor) = entryGapWidth (dùng chung ô hở vành ngoài). Vào ≠ ra -> chute thuôn (như art). Chỉ dùng khi chuteLength > 0.")]
		[SerializeField]
		[Min(0.01f)]
		private float chuteInputWidth;

		[Tooltip("Bán kính BO GÓC (world) chỗ NỐI 2 cạnh chéo (khung) xuống tường chute. 0 = góc nhọn. Canh theo art. Chỉ dùng khi chuteLength > 0.")]
		[SerializeField]
		[Min(0f)]
		private float chuteJunctionCornerRadius;

		[Tooltip("Dựng 2 tường khung TĨNH trái/phải ôm cột tranh (từ đáy tranh lên nóc) để hạt swipe hất lên KHÔNG bay ra 2 bên (§0m B1: khung chỉ 2 cạnh L/R, đỉnh hở nhờ boundary-limits). Tắt = chỉ boundary-limits giữ.")]
		[SerializeField]
		private bool buildFrameWalls;

		[Tooltip("Chiều cao tường khung (LOCAL, ×RigGeometryScale ra world) tính từ đỉnh phễu lên. Cộng FrameWallExtraHeight.")]
		[SerializeField]
		[Min(0f)]
		private float frameWallHeight;

		[Tooltip("KÉO DÀI khung THÊM ngoài FrameWallHeight (LOCAL, ×RigGeometryScale). 0 = đúng FrameWallHeight; >0 = tường vươn cao hơn (hạt hất lên không bay ra).")]
		[SerializeField]
		[Min(0f)]
		private float frameWallExtraHeight;

		[Tooltip("Bán kính BO GÓC (world) cho 4 GÓC khung tranh (2 góc nóc + 2 góc đáy chỗ tường dọc gặp cạnh chéo). 0 = góc nhọn. Canh theo art khung bo tròn. Cần BuildFrameWalls (2 góc nóc cần cả BuildTopWall).")]
		[SerializeField]
		[Min(0f)]
		private float frameCornerRadius;

		[Tooltip("Dựng thêm 1 thanh collider NGANG ĐÓNG KÍN NÓC khung (nối 2 đỉnh tường khung L/R tại y = nóc tranh) -> hạt bị swipe/depenetration hất LÊN không bay ra ngoài đỉnh tranh gây STUCK game. Cần BuildFrameWalls bật (lấy 2 tường L/R làm cạnh). Trước đây đỉnh HỞ, chỉ boundary-limits kill hạt văng ra.")]
		[SerializeField]
		private bool buildTopWall;

		[Tooltip("(LEAK P3 seam tường<->tranh) ĐẨY tường khung L/R RA NGOÀI thêm N world-unit. VÌ SAO: mặt vật lý tường (centerline - EdgeRadius) design FLUSH với mép tranh, nhưng tường clamp TÂM hạt ở thr = EdgeRadius + GrainParticleRadius -> tâm hạt bị ép LÚN đúng 1 bán kính hạt (0.12 world, đo P1 2026-07-29 = 0.119) vào cột tranh rìa còn Solid -> tường và occupancy giằng nhau (hạt kẹt xoay tại seam + ratchet xuyên tranh mỏng). Đặt = GrainParticleRadius để mặt clamp-tâm trùng mép tranh (hạt tựa tường thì THÂN chạm mép tranh, tâm ở ngoài). 0 = TẮT = hình học cũ nguyên si. Per-Build — đổi lúc play chỉ ăn từ level sau.")]
		[SerializeField]
		[Min(0f)]
		private float frameWallOutset;

		[Tooltip("§0c/§0o O4. Gom TỐI ĐA N pixel cùng màu -> 1 hạt (carriedCount). WP-D dùng khi convert; WP-B dùng làm carriedCount mặc định khi AcceptSand.pixelCount<=0.")]
		[SerializeField]
		[Range(1f, 16f)]
		private int maxGroupSize;

		[Tooltip("§0h/§0o O8. Giây giữa các ĐỢT convert wavefront (WP-D). Không dùng ở WP-B.")]
		[SerializeField]
		[Min(0f)]
		private float waveInterval;

		[Tooltip("Vận tốc phọt mặc định khi emit (world m/s, §14 V2) — dùng khi AcceptSand.worldVel ~0. Cao -> R1.")]
		[SerializeField]
		[Min(0f)]
		private float emitSpeed;

		[Tooltip("NỬA GÓC CONE emit (độ, quanh hướng thoát PictureDownWorldDir): vận tốc phọt = Rotate(down, ±góc random)·emitSpeed -> cụm hạt tản XUỐNG + 2 BÊN, KHÔNG BAO GIỜ ngược hướng down (thay emitFanSpeed cũ — fan cộng ngang có thể ngóc lên khi fan > emitSpeed). 0 = phọt thẳng theo down; ~45 tản vừa.")]
		[SerializeField]
		[Range(0f, 89f)]
		private float emitConeHalfAngleDeg;

		[Tooltip("LUẬT CÁT-CHẢY-XUỐNG — ĐỘ CHÉO của đường thoát: số ô NGANG cát được trượt trên MỖI hàng tụt xuống. Pixel tranh chỉ TAN khi có đường ra khỏi khung theo độ chéo này (KHÔNG được trèo lên) -> túi lõm/bát giữ nguyên thay vì tan ra rồi bẫy hạt. Vùng tan từ 1 lỗ thoát = hình NÓN mở LÊN, nửa góc = atan(knob) so với phương ĐỨNG: 0 = giếng thẳng đứng (chỉ tan đúng cột dưới chân); 1 = 45°; 2 ≈ 63°; 3 ≈ 72°; 8 ≈ 83° (CTO chốt 2026-07-17 — gần 'ngang tự do', ưu tiên tranh tan mượt). Góc nghỉ THẬT của cát ~34° so với phương ngang = ~56° so với phương đứng (giữa 1 và 2) -> knob CAO hơn mức đó là CỐ Ý nới cho gameplay, KHÔNG phải mô phỏng đúng: grid sẽ hứa đường thoát mà solver không giao -> hạt đọng lại ở chỗ grid bảo thoát được. Thấp -> phải đào đúng đường xuống mới tan. Chi phí O(W·H) KHÔNG đổi theo knob (nằm trong lượt quét ngang, không nhân vào).")]
		[SerializeField]
		[Range(0f, 8f)]
		private int grainEscapeSlideCells;

		[Tooltip("Số VÒNG occ-cell tối đa mà ConversionFront quét quanh centroid để tìm chỗ SPAWN hở khi convert pixel->hạt (FindClearSpawnPos). Đo live 2026-07-30: ở dải sát đáy tranh gần như MỌI ứng viên ring bị line-of-sight bác -> nhóm nào cũng trả tiền quét trọn (2N+1)² ô × (AABB + LOS) rồi rơi về nhánh anchor. HẠ số này = cắt thẳng chi phí đó (5 -> 2 giảm ~4× số ô quét) đổi lấy điểm spawn kém tối ưu hơn ở các nhóm mà ring VẪN thắng. 0 = chỉ thử đúng ô centroid, fail là spawn tại ô vừa ConvertCell gần nhất.")]
		[SerializeField]
		[Range(0f, 8f)]
		private int grainSpawnClearanceRings;

		[Tooltip("TỐC ĐỘ tan túi — số ô/giây (CTO chốt 2026-07-30, thay 'duration cố định': túi DÀI nên tan lâu hơn túi ngắn, không phải ép mọi túi cùng thời lượng). Cộng ngân sách MỖI FRAME nên đổi waveInterval không đổi tốc độ cảm nhận. Ô bị bỏ qua (không có đường xuống) CŨNG trừ ngân sách -> túi không bao giờ bốc hơi trong 1 đợt. Đặt rất lớn = xả gần như tức thì (mất cảm giác lát).")]
		[SerializeField]
		[Min(1f)]
		private float swipeBatchDrainSpeed;

		[Tooltip("Độ dày LÁT tính bằng SỐ Ô NGÓN TAY ĐI ĐƯỢC: túi chia lát dọc ĐƯỜNG VUỐT (quãng đường tích luỹ, không phải chiếu lên 1 vector -> nét cong/gấp khúc vẫn bám đúng), lát xử lý theo thứ tự vuốt, TRONG lát vẫn ưu tiên py cao nhất (trọng lực). 1 = gần thuần thứ tự chạm (bám ngón tay nhất, dễ trông 'cắt lát'); lớn = gần thuần trọng lực (mượt vật lý, mờ cảm giác hướng).")]
		[SerializeField]
		[Range(1f, 16f)]
		private int swipeBatchSlabCells;

		[Tooltip("DẢI MỎNG TỰ TAN: túi tan xong -> dải tranh Solid dính vào vệt vừa cào mà BỀ DÀY <= số ô này thì gộp thành túi tiếp theo (tan luôn). Lý do: dải mỏng hơn THÂN HẠT (2.34 ô) thì hạt hoặc xuyên qua hoặc đậu lên trên = kẹt vĩnh viễn; dilate chữa được vế xuyên nhưng làm vế kẹt TỆ HƠN, nên lever đúng nằm ở lớp CARVE. 3 = quanh đường kính hạt. 0 = TẮT (dải mỏng nằm lại như cũ). Bề dày đo theo 4 TRỤC (ngang/dọc/2 chéo) — brush tròn hay cắt ra dải CHÉO, đo 2 trục sẽ bỏ sót.")]
		[SerializeField]
		[Range(0f, 8f)]
		private int swipeBatchThinStripCells;

		[Tooltip("TRẦN số ô 1 lượt dải-mỏng-tự-tan gom được (flood lan theo dải liên thông). Dải sót thường là SỢI DÀI: không lan thì tan mỗi khúc sát vệt cào rồi lần sau vẫn kẹt; lan thì hết bug nhưng có thể tan trọn sợi chạy qua nửa tranh mà người chơi chưa cào tới (nhìn như tranh tự rã). Trần này là cái hãm đó. Hạ sát 0 = gần như chỉ tan lớp kề vệt cào.")]
		[SerializeField]
		[Range(0f, 4096f)]
		private int swipeBatchThinStripMaxCells;

		[Tooltip("Bao nhiêu nhát stamp LIÊN TIẾP mà brush RA HẲN khỏi vệt của túi (0 cell mới VÀ không chồng ô nào của túi) thì ĐÓNG túi -> túi đó tan ngay dù tay còn giữ. 1 = đóng ngay khi brush vừa ra khỏi tranh (đúng thiết kế D2). Lớn hơn = khoan dung thêm vài frame khi lượn sát mép. Nhát đè lại vệt vừa cào KHÔNG còn bị tính (fix 2026-07-30) nên KHÔNG cần kéo số này lên để tránh túi đóng vụn ở đầu nét nữa.")]
		[SerializeField]
		[Min(1f)]
		private int swipeBatchEmptyStampsToClose;

		[Tooltip("Pixel HELD mà túi tan xong vẫn KHÔNG có đường xuống (cào hụt) sẽ REVERT về Solid — chọn cách nó sáng lại. Snap = trả alpha 255 ngay. Fade = mọi ô cùng lerp 204->255 trong Revert Duration. WaveBack = lerp LỆCH PHA theo thứ tự drain đảo ngược (sóng sáng chạy ngược phía ngón tay vừa đi). CTO ĐÃ CHỐT WaveBack bằng play-test 2026-08-04 (D9) — asset live cũng đang WaveBack.")]
		[SerializeField]
		private HeldRevertStyle swipeBatchRevertStyle;

		[Tooltip("Thời lượng (giây) hiệu ứng sáng lại khi revert. Style Fade: đây là thời gian lerp. Style WaveBack: nửa đầu dùng để rải lệch pha, nửa sau là thời gian lerp của từng ô. Style Snap bỏ qua số này. 0 = snap.")]
		[SerializeField]
		[Min(0f)]
		private float swipeBatchRevertDuration;

		[Tooltip("TỰ TAN CUỐI MÀN (kênh AUTO-SWIPE) — hạt sinh ra có mang cờ GHOST không: xuyên occupancy TRANH cho tới khi rơi thấp hơn hàng pixel Solid cuối rồi trở lại bình thường (tường khung / belt / cửa VẪN chặn). Off = hành vi cũ, hạt tự tan chịu occupancy như hạt swipe. Trapped Only = chỉ bật khi KHÔNG tìm nổi chỗ hở cỡ thân hạt quanh ô vừa tan (đúng ca 'pixel ở góc/khe hẹp -> hạt sinh ra kẹt luôn tại đó'), hạt sinh ở chỗ thoáng vẫn rơi như thường. Always = MỌI hạt tự tan đều rơi xuyên tranh, giống hệt hạt của booster nổ vùng màu — chọn cái này nếu muốn pha tự tan cuối màn nhìn nhất quán thay vì lúc xuyên lúc không. CHỈ áp cho kênh auto-swipe + retry của nó — nét vuốt của người chơi và dải mỏng KHÔNG đổi 1 bit. ⚠ Hạt đang ghost được vẽ lệch z theo Blast Front Offset (dùng chung với booster nổ vùng màu) nên nó nổi TRƯỚC mặt tranh trong lúc xuyên. ⚠ Thêm LỰC ĐẨY không thay được knob này: vận tốc đâm vào ô occupied bị solver triệt ở cả 3 job, hạt không thiếu năng lượng mà bị chặn hình học.")]
		[SerializeField]
		private AutoSwipeGhostMode autoSwipeGhostMode;

		[Tooltip("Auto-swipe: ghost cả hạt cùng màu ĐÃ tồn tại trong khung (không chỉ hạt vừa convert)")]
		[SerializeField]
		private bool autoSwipeGhostExistingGrains;

		[Tooltip("BÚA — chờ bao lâu (giây, tính từ lúc TAP) rồi mới KHỞI ĐỘNG chuỗi búa. 0 = chạy ngay frame tap. Chuỗi (2026-08-20): đỗ ở HidePos -> anim SHOW -> BAY tới điểm chạm -> anim HIT -> anim HIDE -> đỗ lại HidePos. Ref búa + HidePos + offset + thời gian BAY nằm trên ColorBlastController (art per-scene), CHỈ mốc khởi động ở đây để tune chung với 2 mốc kia.")]
		[SerializeField]
		[Min(0f)]
		[FormerlySerializedAs("blastToolMoveDuration")]
		private float blastHammerDelay;

		[Tooltip("BÁN KÍNH vùng nổ, đơn vị = PIXEL TRANH (không phải world-unit, không phải pixel màn hình): tap vào đâu thì mọi ô nằm trong đĩa tròn bán kính này quanh điểm chạm đều nổ, BẤT KỂ màu. Ô băng / ô đã tan / ô chưa scroll xuống vẫn bị loại như cũ. 0 = booster vô hiệu (tap không nổ gì).")]
		[SerializeField]
		[Min(0f)]
		private float blastRadiusPixels;

		[Tooltip("TRÌ HOÃN CONVERT (giây, tính từ lúc tap): chờ bấy nhiêu rồi mới bắt đầu hoá pixel thành hạt. Pha LOÉ chạy SONG SONG chứ không chặn — để tune cho lúc hạt bung khớp với nhịp của anim. 0 = nổ NGAY lúc tap (anim loé chạy đè lên lúc đang rót). ⚠ Trong khoảng chờ này pixel còn NGUYÊN trên tranh -> bấm huỷ vẫn miễn phí.")]
		[SerializeField]
		[Min(0f)]
		private float blastConvertDelay;

		[Tooltip("Tổng thời gian RÓT cả vùng vừa nổ (giây): mọi nhóm hạt của vùng được thả ĐỀU trong khoảng này, theo thứ tự TỪ DƯỚI LÊN (py giảm dần vì py=0 là đỉnh tranh). 0 = thả HẾT trong 1 frame (vùng to = 1 phát đổ ụp vào phễu, dễ chạm belt-full -> thua). Vùng CÀNG TO thì nhịp thả càng dày, KHÔNG kéo dài thêm.")]
		[SerializeField]
		[Min(0f)]
		private float blastPourDuration;

		[Tooltip("Đẩy hạt ĐANG XUYÊN TRANH ra PHÍA TRƯỚC mặt tranh bao nhiêu world-unit theo trục Z (CÓ DẤU — camera nhìn theo chiều nào thì 'phía trước' là dấu đó, dò tại chỗ). 0 = vẽ đúng mặt phẳng z=0 như mọi hạt (có thể bị phần tranh còn lại che). CHỈ đổi CHỖ VẼ, không đổi vật lý; hạt rơi qua hàng pixel Solid thấp nhất là nhả cờ -> về z=0 ngay.")]
		[SerializeField]
		private float blastFrontOffset;

		[Tooltip("EMIT VÒNG CUNG — tốc NGANG (world/s) mà hạt booster bung ra khỏi tâm vùng vừa nổ. Chiều = VỊ TRÍ hạt so với TÂM vùng (bên trái tâm bay trái, bên phải bay phải; đúng tâm -> random ±), KHÔNG random hai phía. 0 = không tản ngang (rơi thẳng tại chỗ). Đây là knob 'bung rộng bao nhiêu'.")]
		[SerializeField]
		[Min(0f)]
		private float blastLaunchSpeed;

		[Tooltip("EMIT VÒNG CUNG — độ CAO đỉnh cung (world unit) mà hạt vọt lên trước khi rơi. Quy ra vận tốc đầu v = sqrt(2·|GrainGravityY|·height) rồi để TRỌNG LỰC SOLVER lo phần còn lại (parabol tự nhiên, KHÔNG tween ép quỹ đạo). ⚠ ĐỂ NHỎ: vùng ở hàng TRÊN CÙNG tranh + height lớn = hạt đập TƯỜNG NÓC dội xuống (nhìn xấu, không mất cát vì escape-guard teleport về miệng phễu). 0 = không vọt lên.")]
		[SerializeField]
		[Min(0f)]
		private float blastLaunchHeight;

		[Tooltip("EMIT VÒNG CUNG — jitter GÓC (độ, ±) quanh hướng bung đã tính, để cụm hạt không bay song song như in. 0 = mọi hạt cùng bên có vận tốc y hệt nhau.")]
		[SerializeField]
		[Min(0f)]
		private float blastLaunchSpreadDeg;

		[Tooltip("FPS — số pixel/hạt RIÊNG cho booster (0 = dùng MaxGroupSize chung của swipe). Vùng nổ sinh cả cụm hạt trong chớp mắt, mà chi phí solver bám SỐ HẠT: nhóm to gấp đôi = nửa số hạt cho cùng số pixel. Kế toán KHÔNG lệch (mỗi hạt vẫn mang đúng số ô THẬT SỰ tan).\n⚠ Giá phải trả: ColorJar hiển thị sức chứa quy theo MaxGroupSize CHUNG, nên hạt của booster trừ ô đếm trên lọ lệch nhịp (luật ĐẦY lọ vẫn tính theo PIXEL nên không sai kế toán, chỉ sai con số hiển thị).")]
		[SerializeField]
		[Min(0f)]
		private int blastGroupSize;

		[Tooltip("TẮT (mặc định) = hạt booster rơi vào PHỄU khung tranh rồi theo belt như cát cào bình thường.\nBẬT = hạt vẫn bung ra vòng cung y hệt, nhưng NGAY KHI rơi qua đáy tranh (mốc nhả cờ ghost) nó RỜI hệ vật lý và bay thẳng vào LỌ CÙNG MÀU (cung bay + kế toán dùng chung đường của ObiJarSink).\n⚠ Đổi CÂN BẰNG: hạt booster không còn đi qua belt nên KHÔNG còn đẩy belt chạm GrainBeltFullEntry -> búa an toàn hơn hẳn.\n⚠ Không còn lọ nào CÙNG MÀU đủ chỗ cho cả hạt (cuối màn) -> hạt đó tự rơi phễu như khi TẮT, KHÔNG mất cát.")]
		[SerializeField]
		private bool blastDirectToJar;

		public int CapSegments => 0;

		public float EdgeRadius => 0f;

		public float EntryGapWidth => 0f;

		public float FunnelHeight => 0f;

		public float FunnelMouthHalfWidth => 0f;

		public float ChuteLength => 0f;

		public float ChuteInputWidth => 0f;

		public float ChuteJunctionCornerRadius => 0f;

		public bool BuildFrameWalls => false;

		public float FrameWallHeight => 0f;

		public float FrameWallExtraHeight => 0f;

		public float FrameCornerRadius => 0f;

		public bool BuildTopWall => false;

		public float FrameWallOutset => 0f;

		public float EmitSpeed => 0f;

		public float EmitConeHalfAngleDeg => 0f;

		public int GrainEscapeSlideCells => 0;

		public int MaxGroupSize => 0;

		public int GrainSpawnClearanceRings => 0;

		public float WaveInterval => 0f;

		public float SwipeBatchDrainSpeed => 0f;

		public int SwipeBatchSlabCells => 0;

		public int SwipeBatchThinStripCells => 0;

		public int SwipeBatchThinStripMaxCells => 0;

		public int SwipeBatchEmptyStampsToClose => 0;

		public HeldRevertStyle SwipeBatchRevertStyle => HeldRevertStyle.Snap;

		public float SwipeBatchRevertDuration => 0f;

		public AutoSwipeGhostMode AutoSwipeGhostMode => AutoSwipeGhostMode.Off;

		public bool AutoSwipeGhostExistingGrains => false;

		public float BlastRadiusPixels => 0f;

		public float BlastHammerDelay => 0f;

		public float BlastConvertDelay => 0f;

		public float BlastPourDuration => 0f;

		public float BlastFrontOffset => 0f;

		public float BlastLaunchSpeed => 0f;

		public float BlastLaunchHeight => 0f;

		public float BlastLaunchSpreadDeg => 0f;

		public int BlastGroupSize => 0;

		public bool BlastDirectToJar => false;

		public int GrainThrottleEntry => 0;

		public int GrainThrottleExit => 0;

		public float GrainsPerPixelDivisor => 0f;

		public float GrainGravityY => 0f;

		public float GrainParticleRadius => 0f;

		public int GrainSubsteps => 0;

		public float GrainDespawnY => 0f;

		public int GrainMaxSolverStepsPerFrame => 0;

		public float GrainMaxStepDt => 0f;

		public float GrainWallRestitution => 0f;

		public float GrainWallFriction => 0f;

		public bool GrainFunnelSlideEnabled => false;

		public float GrainFunnelSlideSpeed => 0f;

		public float GrainFunnelSlideCoupling => 0f;

		public float GrainFunnelSlideMinSpeed => 0f;

		public float GrainWallCompliance => 0f;

		public bool GrainWallGridEnabled => false;

		public float GrainWallGridCellMul => 0f;

		public bool GrainWallGridIntegrate => false;

		public float GrainBeltSpeed => 0f;

		public float GrainBeltCoupling => 0f;

		public bool GrainBeltOneWay => false;

		public float GrainBeltRadialDamping => 0f;

		public float GrainBeltTopRelease => 0f;

		public float GrainBeltTopReleaseStart => 0f;

		public float GrainBeltTopTangentDamp => 0f;

		public float GrainBeltUpSpeed => 0f;

		public float GrainBeltUpCoupling => 0f;

		public float GrainBeltUpRadialDamping => 0f;

		public float GrainBeltUpTopRelease => 0f;

		public float GrainBeltUpTopReleaseStart => 0f;

		public float GrainBeltUpTopTangentDamp => 0f;

		public float GrainBeltSpeedBoostRate => 0f;

		public float GrainBeltCouplingBoostRate => 0f;

		public float GrainBeltRadialDampingBoostRate => 0f;

		public float GrainBeltUpSpeedBoostRate => 0f;

		public float GrainBeltUpCouplingBoostRate => 0f;

		public float GrainBeltUpRadialDampingBoostRate => 0f;

		public float GrainBeltFullEntry => 0f;

		public float GrainBeltFullExit => 0f;

		public float GrainBeltFullTimeoutSeconds => 0f;

		public float GrainBeltFullPreLostSeconds => 0f;

		public float GrainGateWallYOffset => 0f;

		public float GrainGateWallThicknessMul => 0f;

		public float GrainGateWallSpeed => 0f;

		public float GrainBlowerCaptureMarginRadii => 0f;

		public int GrainContactIterations => 0;

		public float GrainContactStiffness => 0f;

		public float GrainContactSoftness => 0f;

		public float GrainContactIntruderBias => 0f;

		public float GrainContactMaxPush => 0f;

		public float GrainContactDamping => 0f;

		public float GrainContactAbsorbCapMul => 0f;

		public float GrainContactSettleDamping => 0f;

		public float GrainFrictionVelocity => 0f;

		public float GrainFrictionSurfaceDrag => 0f;

		public float GrainFrictionPosMu => 0f;

		public float GrainGrainCcdGate => 0f;

		public float GrainGrainCcdMaxPull => 0f;

		public bool GrainNeighborGridEnabled => false;

		public int GrainNeighborGridSubdiv => 0;

		public bool GrainNeighborPackEnabled => false;

		public bool GrainNeighborPackSplit => false;

		public float GrainOccupancyPushStrength => 0f;

		public float GrainOccupancyMaxStep => 0f;

		public float GrainOccupancySlip => 0f;

		public int GrainOccupancySmoothRadius => 0;

		public int GrainOccupancyDilateCells => 0;

		public float GrainSurfaceCreepSpeed => 0f;

		public float GrainSurfaceCreepSlopeMin => 0f;

		public int GrainSurfaceCreepWindow => 0;

		public int GrainCreepLateralMax => 0;

		public int GrainOccupancyEjectSearchCells => 0;

		public float GrainScrollRowsPerSecond => 0f;

		public int GrainScrollClearGrainMax => 0;

		public float GetBeltLevelMultiplier(int level)
		{
			return 0f;
		}
	}
}
